using System;

namespace WindowsFormsApplication1
{
    /* To collapse  all prese : Ctrl + 'M' + 'O'*/
    /* To open      all prese : Ctrl + 'M' + 'L'*/
    public class Vigenere
    {
        /* Variable of this class*/
        public string plainText
        {
            get
            {
                return _plainText;
            }
            set
            {
                _plainText = value;
                encrypt(_plainText, key);
            }
        }
        public string key { get; set; }
        public static float[] LetterFrequencyTable = {
                8.167f / 100, // A
                1.492f / 100, // B
                2.782f / 100, // C
                4.253f / 100, // D
                12.702f / 100,// E
                2.228f / 100, // F
                2.015f / 100, // G
                6.094f / 100, // H
                6.966f / 100, // I
                0.153f / 100, // J
                0.772f / 100, // K
                4.025f / 100, // L
                2.406f / 100, // M
                6.749f / 100, // N 
                7.507f / 100, // O
                1.929f / 100, // P
                0.095f / 100, // Q
                5.987f / 100, // R
                6.327f / 100, // S
                9.056f / 100, // T
                2.758f / 100, // U
                0.978f / 100, // V
                2.360f / 100, // W
                0.150f / 100, // X
                1.974f / 100, // Y
                0.074f / 100  // Z
    };
        private static int totalLetters = 26;
        private static float OPTINAL_IC = 1.73f;
        private int amountOnlyLetter { get; set; }
        private string _plainText;

        /* Constractures */
        public Vigenere()
        {
            plainText = "";
            key = "";
            CountLetterFromPlainText();
        }
        public Vigenere(string _plainText, string _key) : this()
        {
            plainText = _plainText;
            if(_key != null)
            {
                key = _key;
                encrypt(_plainText, key);
            }
            CountLetterFromPlainText();
        }

        private string filterInvalidChars(string _cipherText)
        {
            string filtered = "";
            foreach (Char c in _cipherText)
            {
                if (Char.IsLetter(c))
                {
                    filtered += c.ToString();
                }
            }
            return filtered;
        }
        
        /* Mission 1*/

        /* encrypt the plaintext with parameter key = got a cipherText*/
        private char encryptLetter(char c, char shift)
        {
            if (!Char.IsLetter(c)) return '#';
            shift = getCharResponseToAnotherChar(c, shift);
            char helpConvert = Char.IsUpper(c) ? 'A' : 'a';
            return (char)(helpConvert + ((c - helpConvert) + (shift - helpConvert)) % totalLetters);
        }
        private char encryptLetter(char c, int shift)
        {
            return encryptLetter(c, (char)shift);
        }
        public string encrypt(string _plainText, string _key)
        {
            string cipherText = "";
            if (_key == null && key == null) {
                return "ERROR : you forget to send a key to enctypt";
            }
            if (_key != null)
                key = _key;
            if (key.Length == 0)
                return "";

            for (int i = 0; i < _plainText.Length; i++)
            {
                cipherText += Char.IsLetter(_plainText[i]) ? 
                    encryptLetter(_plainText[i], key[i % key.Length]).ToString() :
                    _plainText[i].ToString();
            }
            return cipherText;
        }

        /* decrypt the cipherText with parameter key = got a decryptText*/
        private char decryptLetter(char c, char shift)
        {
            if (!Char.IsLetter(c)) return '#';
            shift = getCharResponseToAnotherChar(c, shift);
            char helpConvert = getCharResponseToAnotherChar(shift, 'A');
            int diff = (c - shift);
            if (diff < 0)
                diff = totalLetters + diff;
            return (char)(helpConvert + ((diff) % totalLetters));
        }
        private char decryptLetter(char c, int shift)
        {
            return decryptLetter(c, (char)shift);
        }
        public string decrypt(string _cipherText, string _key)
        {
            string decryptText = "";
            for (int i = 0; i < _cipherText.Length; i++)
            {
                decryptText += Char.IsLetter(_cipherText[i]) ? 
                    decryptLetter(_cipherText[i], _key[i % _key.Length]).ToString() :
                    _cipherText[i].ToString();
            }
            return decryptText;
        }

        /* Help methods */
        private char toUpperChar(char s)
        {
            int subFromLower = ('a' - 'A'); // 97 - 65 = 32
            return Char.IsUpper(s) ? s : (char)(s - subFromLower);
        }
        private char toLowerChar(char s)
        {
            int addToLower = ('a' - 'A'); // 97 - 65 = 32
            return Char.IsLower(s) ? s : (char)(s + addToLower);
        }
        private char getCharResponseToAnotherChar(char other, char toReturn)
        {
            return Char.IsLower(other) ? toLowerChar(toReturn) : toUpperChar(toReturn);
        }

        /* ------------------------------------------------------------------------------------ */
        /* Mission 2*/
        /* get the frequncy of the letters in the cipherText */
        private int getFrequncyForCharInCiphertext(char ch, string _ciphertext)
        {
            int count = 0;
            for (int i = 0; i < _ciphertext.Length; i++)
            {
                ch = getCharResponseToAnotherChar(_ciphertext[i], ch);
                count = _ciphertext[i] == ch ? count + 1 : count;
            }
            return count;
        }
        public int[] getFrequncyLetters(string _ciphertext = null)
        {
            int[] freq = new int[totalLetters];
            for (int i = 0; i < totalLetters; i++)
            {
                freq[i] = getFrequncyForCharInCiphertext((char)('A' + i), _ciphertext);
            }
            return freq;
        }

        private int CountLetterFromPlainText(string _plainText = null)
        {
            if (_plainText == null) _plainText = plainText;
            int count = 0;
            for (int i = 0; i < _plainText.Length; i++)
            {
                count = Char.IsLetter(_plainText[i]) ? count + 1 : count;
            }
            return count;
        }

        /* ------------------------------------------------------------------------------------ */
        /* Mission 3                                                                            */
        /* Calculate the IC value by the following formula:                                     */
        /*      ∑_𝛼 𝑛_𝛼(𝑛_𝛼 − 1)                                                                */
        /* IC = ----------------                                                                */
        /*       𝑁(𝑁 − 1) / C                                                                  */
        /*                                                                                      */
        /*  •) 𝑛_𝛼  = frequnce of the letter a in the chipertext                                */
        /*  •) C    = amount of the letter of the A-Z (26)                                      */
        /*  •) 𝑁    = the amount of the letters in the chipertext                               */
        /*  •) IC   = should be approximate to 1.73                                             */
        /*______________________________________________________________________________________*/
        public double calculate_IC(string _ciphertext)
        {
            
            double IC = 0.0;
            int Sigma = 0; // ∑_𝛼
            int n_i = 0;
            int N = _ciphertext.Length;
            int C = totalLetters;
            int[] frequncies = getFrequncyLetters(_ciphertext); // for - 𝑛_i

            int Minimum_Frequence = 2;

            for (int i = 0; i < totalLetters; i++)
            {
                n_i = frequncies[i];
                Sigma += n_i >= Minimum_Frequence ? (n_i * (n_i - 1)) : 0;
            }

            IC = (Sigma) / ((double)(N * (N - 1)) / C);
            return IC;
        }

        /* return the length of the key , by the Average IC which closest the 1.73 per length from 1 to 15 */
        public int getKeyLength(string _ciphertext = null)
        {
            int key_result = 0;
            int MAX_KEY = 15;
            int MIN_KEY = 1;
            double final_IC = 0.0;
            double IC = 0.0;

            for (int key_len = MIN_KEY; key_len <= MAX_KEY; key_len++)
            {
                // for example =>  |k| = 3
                // HADRIELBENJO
                // H    A   D
                // R    I   E
                // L    B   E
                // J    O   -
                // K0   K1  K2
                // ------------
                // K0 => HRLJ   // get letter-frequencies(HRLJ) and calc the IC_0 = xyz
                // K1 => AIBO   // get letter-frequencies(AIBO) and calc the IC_1 = xyz
                // k2 => DEE    // get letter-frequencies(DEE ) and calc the IC_2 = xyz
                // 
                // Average_IC_keylen = IC_keylen / keylen , the keylen is calculated between the value 1-15
                // Average_i -> 1.73 (optimal IC) then IC = Average_i AND key length = 3
                // the key length value is according to the soonest average

                IC = 0.0;
                string _ciphertext_column = "";
                for (int index_key = 0; index_key < key_len; index_key++) //index of the column ,like k1 
                {
                    for (int c = 0; c < _ciphertext.Length; c++)
                    {
                        if (index_key == c % key_len)               // like : A, I, B , O  in the k1 (from the above example)
                        {
                            _ciphertext_column += _ciphertext[c];   // append each letter from the ciphertex of the column k like K1
                        }

                    }
                    IC += calculate_IC(_ciphertext_column); // ∑ - sum the IC's of the all columns ciphertext, IC_keylen
                    
                }
                if (key_len == MIN_KEY)   // the first guess - this is the minimal key
                {
                    final_IC = IC;
                }

                IC = IC / key_len; // Average_IC_keylen = IC_keylen / keylen;

                // update the final IC of the closest to 1.73 (optimal IC) AND the best key 
                if (Math.Abs(OPTINAL_IC - IC) <= Math.Abs(OPTINAL_IC - final_IC)) 
                {
                    final_IC = IC;
                    key_result = key_len;
                }
            }
            return key_result;
        }

        /* ------------------------------------------------------------------------------------ */
        /* Mission 4*/
        /* Return the correct encrypt key, for the Plain Text that read the most */
        /* (As the text is larger and written more correctly, So the result will be more accurate)*/
        public string getFinalKey(string _cipherText = null)
        {
            _cipherText = filterInvalidChars(_cipherText);
            string finalKey = "";
            string _encryptText = "";
            string ciphertext_Column = "";

            int keyLength = getKeyLength(_cipherText); 
            int[] LetterFrequency = new int[totalLetters]; //each index presents letter of abc a=0,b=1
            int encryptLetterIndex = 0;

            double Corelation_X = 0.0;
            double tempX = 0.0;

            // Get the Correct lenght of the key -> like len = 3
            // for each column in the ciphertext by index key 
            // like: HADRIELBENJO
            // H    A   D
            // R    I   E
            // L    B   E
            // J    O   -
            // K0   K1  K2
            // -------------
            // we calculate her relative frequncy in this ciphertext column
            // then try for each letter from the A-Z to calculate the match to the real key value
            // by the following formula: 𝑋 = ∑ 𝑛𝛼𝑓
            // X is the coralation to letter to show, we take the best X (max)     
            // and so on, we get the key string

            for (int i = 0; i < keyLength; i++)
            {
                ciphertext_Column = "";
                Corelation_X = 0.0;

                // get the ciphertext column by index key
                for (int j = 0; j < _cipherText.Length; j++) 
                {
                    if (j % keyLength == i)
                        ciphertext_Column += _cipherText[j];
                }

                // check each letter of A-Z the frequency of the letter and the frequncy table to determain the coralation
                for (int letter_index = 0; letter_index < totalLetters; letter_index++) 
                {
                    tempX = 0.0;
                    string _key_cipther = ((char)('A' + letter_index)).ToString();
                    // decrype the column of cipher text using each letter of the abc
                    _encryptText = decrypt(ciphertext_Column, _key_cipther); 
                    LetterFrequency = getFrequncyLetters(_encryptText.ToUpper());

                    for (int k = 0; k < totalLetters; k++)
                        tempX += (LetterFrequencyTable[k] * LetterFrequency[k]); // calculate X Coralation according the given formula

                    // the best Coralation - will be tokken and update the letter to add him letter to the key
                    if (tempX > Corelation_X) 
                    {
                        Corelation_X = tempX;
                        encryptLetterIndex = letter_index; // The correct encrypt key letter
                    }
                }
                // save/add the letter to the key , and check the next letter in the loop
                finalKey += ((char)('A' + encryptLetterIndex)).ToString(); 
            }
            return finalKey;
        }

    }
}
