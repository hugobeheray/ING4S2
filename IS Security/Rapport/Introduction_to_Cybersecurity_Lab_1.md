# Introduction to Cybersecurity : Lab 1



###  Exercise ”Asymmetric cryptography”



### 1. 

- *Repeat the same steps for Bob* 

```
sh-3.2# cd Bob
sh-3.2# ls
sh-3.2# openssl genrsa -out BobKeyPair
Generating RSA private key, 2048 bit long modulus
..................+++
....................+++
e is 65537 (0x10001)
sh-3.2# ls
BobKeyPair
sh-3.2# openssl rsa -in BobKeyPair -pubout -out BobPublicKey
writing RSA key
sh-3.2# ls
BobKeyPair    BobPublicKey
sh-3.2# mv BobKeyPair BobPrivateKey
sh-3.2# ls
BobPrivateKey    BobPublicKey
sh-3.2# pwd
/Users/hugobeheray/Documents/ING4S2/IS Security/LAB1/Bob
sh-3.2#
```



### 2.

- *Go back to the parent folder LAB1 and access Alice’s folder*

`sh-3.2# cd ..` 

`sh-3.2# cd Alice/` 



- *Check that BobPublicKey has been copied correctly to Alice’s folder*

```
sh-3.2# ls AliceDocument    AlicePrivateKey    AlicePublicKey    BobPublicKey
sh-3.2#
```



- *Check that AliceDocumentEncrypted has been created correctly*

```
openssl rsautl -encrypt -in AliceDocument -pubin -inkey BobPublicKey -out AliceDocumentEncrypted
sh-3.2# ls
AliceDocument        AliceDocumentEncrypted    AlicePrivateKey        AlicePublicKey        BobPublicKey
sh-3.2# gedit AliceDocumentEncrypted
```



- *Check the content of the file AliceDocumentEncrypted*

![img](https://cdn.discordapp.com/attachments/513752539016069123/934409369964130344/Capture_decran_2022-01-22_a_12.29.00.png)

We notice that the message "Hello Bob I'm Alice" has been encrypted using incomprehensible characters.



### 3.

- *Make sure you are in Alice’s folder. We ask you to copy AliceDocumentEncrypted to Bob’s folder*

```
sh-3.2# pwd
/Users/hugobeheray/Documents/ING4S2/IS Security/LAB1/Alice
sh-3.2# cp /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB1/Alice/AliceDocumentEncrypted /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB1/Bob/
sh-3.2#
```



- *Go back to the parent folder LAB1 and access Bob’s folder* 

```
sh-3.2# cd ..
sh-3.2# cd Bob
```



- *Check that AliceDocumentEncrypted has been copied correctly to Bob’s folder*

```
sh-3.2# ls
AliceDocumentEncrypted    BobPrivateKey        BobPublicKey
```



- *Decrypt AliceDocumentEncrypted thanks to BobPrivateKey*

```
sh-3.2# openssl rsautl -decrypt -in AliceDocumentEncrypted  -inkey BobPrivateKey -out AliceDocumentDecrypted
```



- *Check that AliceDocumentDecrypted has been created correctly*

```
sh-3.2# ls
AliceDocumentDecrypted    AliceDocumentEncrypted    BobPrivateKey        BobPublicKey
```



-  *Check the content of the file AliceDocumentDecrypted. What do you notice?*

![img](https://cdn.discordapp.com/attachments/513752539016069123/934413353898635294/Capture_decran_2022-01-22_a_12.44.55.png)We notice that the document has been decrypted correctly because we can see the previous message wrote in AliceDocument.



### 4.

- *Go back to the parent folder LAB1 and access Alice’s folder*

```
sh-3.2# cd ..
sh-3.2# cd Alice
sh-3.2# pwd
/Users/hugobeheray/Documents/ING4S2/IS Security/LAB1/Alice
```



- *Try now to encrypt LargeFile by using BobPublicKey and by naming the encrypted file LargeFileEncrypted*

```
sh-3.2# openssl rsautl -encrypt -in LargeFile -pubin -inkey BobPublicKey -out LargeFileEncrypted
RSA operation error
4492301996:error:04FFF06E:rsa routines:CRYPTO_internal:data too large for key size:/System/Volumes/Data/SWE/macOS/BuildRoots/5b2e67f8af/Library/Caches/com.apple.xbs/Sources/libressl/libressl-75.60.3/libressl-2.8/crypto/rsa/rsa_pk1.c:151:
sh-3.2#
```



### 5.

-  *Create a file named AuthData and write a text of your choice*

```
sh-3.2# pwd
/Users/hugobeheray/Documents/ING4S2/IS Security/LAB1/Alice
sh-3.2# gedit AuthData
```



- *Check that AuthData has been created correctly*

```
sh-3.2# ls
AliceDocument        AlicePrivateKey        AuthData        LargeFile
AliceDocumentEncrypted    AlicePublicKey        BobPublicKey        LargeFileEncrypted
```



-  *Copy AlicePublicKey to Bob’s folder*

```
sh-3.2# cp /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB1/Alice/AlicePublicKey /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB1/Bob/
sh-3.2# cd ..
sh-3.2# cd Bob
sh-3.2# ls
AliceDocumentDecrypted    AliceDocumentEncrypted    AlicePublicKey        BobPrivateKey        BobPublicKey
```



- *Check that HashAuthData has been created correctly*

```
sh-3.2# openssl dgst -sha256 -out HashAuthData AuthData
sh-3.2# l
sh: l: command not found
sh-3.2# ls
AliceDocument        AlicePrivateKey        AuthData        HashAuthData        LargeFileEncrypted
AliceDocumentEncrypted    AlicePublicKey        BobPublicKey        LargeFile
```



- *Check the content of HashAuthData*

![img](https://cdn.discordapp.com/attachments/513752539016069123/934417126440189982/Capture_decran_2022-01-22_a_12.59.55.png)



- *You will now proceed to sign HashAuthData thanks to AlicePrivateKey by naming the signature AliceSignature*

```
openssl rsautl -sign -in HashAuthData -inkey AlicePrivateKey -out AliceSignature
```



- *Check that AliceSignature has been created correctly*

```
sh-3.2# ls
AliceDocument        AlicePrivateKey        AliceSignature        BobPublicKey        LargeFile
AliceDocumentEncrypted    AlicePublicKey        AuthData        HashAuthData        LargeFileEncrypted
```



- *Copy AliceSignature and AuthData to Bob’s folder*

```
sh-3.2# cp /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB1/Alice/AliceSignature /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB1/Bob/
sh-3.2# cp /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB1/Alice/AuthData /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB1/Bob/
```



- Go back to the parent folder LAB1 and access Bob’s folder

```
sh-3.2# cd ..
sh-3.2# cd Bob
sh-3.2# pwd
/Users/hugobeheray/Documents/ING4S2/IS Security/LAB1/Bob
```



- Check that AliceSignature and AuthData have been copied correctly to Bob’s folder

```
sh-3.2# ls
AliceDocumentDecrypted    AliceDocumentEncrypted    AlicePublicKey        AliceSignature        AuthData        BobPrivateKey        BobPublicKey
```



- *Check that HashAuthData has been retrieved correctly*

![img](https://cdn.discordapp.com/attachments/513752539016069123/934419667634778152/Capture_decran_2022-01-22_a_13.10.01.png)



- *Check that HashBob has been created correctly*

```
sh-3.2# openssl dgst -sha256 -out HashBob AuthData
sh-3.2# ls
AliceDocumentDecrypted    AlicePublicKey        AuthData        BobPublicKey        HashBob
AliceDocumentEncrypted    AliceSignature        BobPrivateKey        HashAuthData
```

