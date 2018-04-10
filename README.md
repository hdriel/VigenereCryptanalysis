# Vigenere Cryptanalysis

### a C# project

I have implemented a program that encodes and decodes Vigenère codes, and if the text is written correctly in English, with a relatively long story that allows statistical analysis of the repetition of letters, then the key of the code (and of course the code itself) can be decoded by Index of consistency.
Otherwise, brute force must be applied to any possible key size on all letters in order to try to decode the Vigenère code.

### Introduction to concepts: 
--- 

## **[Vigenère cipher](https://en.wikipedia.org/wiki/Vigenère_cipher)**

In a Caesar cipher, each letter of the alphabet is shifted along some number of places; for example, in a Caesar cipher of shift 3, A would become D, B would become E, Y would become B and so on. The Vigenère cipher consists of several Caesar ciphers in sequence with different shift values.

To encrypt, a table of alphabets can be used, termed a tabula recta, Vigenère square, or Vigenère table. It consists of the alphabet written out 26 times in different rows, each alphabet shifted cyclically to the left compared to the previous alphabet, corresponding to the 26 possible Caesar ciphers. At different points in the encryption process, the cipher uses a different alphabet from one of the rows. The alphabet used at each point depends on a repeating keyword.[citation needed]

For example, suppose that the plaintext to be encrypted is:

ATTACKATDAWN
The person sending the message chooses a keyword and repeats it until it matches the length of the plaintext, for example, the keyword "LEMON":

LEMONLEMONLE
Each row starts with a key letter. The remainder of the row holds the letters A to Z (in shifted order). Although there are 26 key rows shown, one will only use as many keys (different alphabets) as there are unique letters in the key string, here just 5 keys, {L, E, M, O, N}. For successive letters of the message, we are going to take successive letters of the key string, and encipher each message letter using its corresponding key row. Choose the next letter of the key, go along that row to find the column heading that matches the message character; the letter at the intersection of [key-row, msg-col] is the enciphered letter.

--- 

## **[Index of coincidence](https://en.wikipedia.org/wiki/Index_of_coincidence)**

In cryptography, coincidence counting is the technique (invented by William F. Friedman[1]) of putting two texts side-by-side and counting the number of times that identical letters appear in the same position in both texts. This count, either as a ratio of the total or normalized by dividing by the expected count for a random source model, is known as the index of coincidence, or IC for short.

---

several pictures from the program: 

![](https://profile.fcdn.co.il/images/0__05acc01348e205.jpg)
![](https://profile.fcdn.co.il/images/0__05acc0140acdc0.jpg)
![](https://profile.fcdn.co.il/images/0__05acc014eb3f9c.jpg)
![](https://profile.fcdn.co.il/images/0__05acc0178ea4f6.jpg)
