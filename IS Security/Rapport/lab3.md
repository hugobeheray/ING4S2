# LAB3

---

## Authors

- Hugo BEHERAY
- Zoé CROUZET

---

### Exercise "Preparation of cryptographic security elements for each actor"

- _The CARoot has a key pair CAPubKey and CAPrivKey and a self-signed certificate CACert.crt. We ask you to generate for CARoot these cryptographic security elements_

We generate the key pair by using genrsa command. Then we split it in two, the private key and the public key.

For the Private and Public keys:

```sh
openssl genrsa -out CaKeyPair
openssl rsa -in CaKEY -pubout -out CAPubKey
mv CaKEY CAPrivKey
ls
CAPrivKey CAPubKey
```

For the self-signed certificate:

We create CACert by signing it with the CA private key.

```sh
openssl req -x509 -new -key CAPrivKey -out CACert.crt -days 500
ls
CACert.crt  CAPrivKey   CAPubKey   CaKeyPair
```

- _The Server has also a key pair ServerPubKey and ServerPrivKey. We ask you to generate for the Server these cryptographic security elements._

We do the same step as before to create the public and private key.

```sh
cd Server/
openssl genrsa -out ServerKeyPair
openssl rsa -in ServerKeyPair  -pubout -out ServerPubKey
mv ServerKeyPair ServerPrivKey
ls
ServerPrivKey   ServerPubKey
```

- _The Client does not have any key._

- _The Server needs to create a request for a certificate ServerRequest.csr. Afterwards, it will send this request to CARoot. We ask you to create for the Server ServerRequest.csr and send it to CARoot (by using the copy command as we have seen in the last session)._

We create the request for a certificate by entering this command:

```sh
openssl req -new -newkey rsa:4096 -nodes -keyout ServerKeyPair.key -out ServerRequest.csr
```

Then we copy it in the CARoot folder by using this command:

```sh
cp /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB3/Server/ServerRequest.csr /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB3/CARoot
cd ..
cd CARoot/
ls
CACert.crt  CAPrivKey   CAPubKey    CaKeyPair   ServerRequest.csr
```

- _CARoot will generate ServerCert.crt and send it to the Server. We ask you to generate ServerCert.crt and send it to the Server._

We generate ServerCert using the Server request, CACert and the CA private key.

```sh
openssl x509 -req -in ServerRequest.csr -CA CACert.crt -CAkey CAPrivKey -CAcreateserial -out ServerCert.crt -days 500 -sha256
Signature ok
subject=/C=FR/ST=IDF/L=Paris/O=ECE/OU=IS/CN=secu/emailAddress=student@ece.fr
Getting CA Private Key
#then we send it to server
cp ServerCert.crt /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB3/Server
```

- _CARoot will also send CACert.crt to the Server and the Client. Consequently, The Server and Client store CACert.crt as a Trusted Third Party. We ask you to send CACert.crt to the Server and the Client._

```sh
#we copy CACert in the Client
cp /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB3/CARoot/CACert.crt /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB3/Client

#we copy CACert in the Server
cp /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB3/CARoot/CACert.crt /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB3/Server
```

### Exercise "TLS Protocol"

- _The Client generates a file RNc. We ask you to create RNc and write a random number of your choice. Afterwards, you need to send it to the Server (by using the copy command as we have seen in the last session)_

```sh
touch RNc
vim RNc #we chose 12 as a random number
cp /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB3/Client/RNc /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB3/Server
```

- _The Server generates a file RNs. We ask you to create RNs and write a random number of your choice. Afterwards, you need to send it to the Client_

```sh
touch RNs
vim RNs #we chose 27 as a random number
cp /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB3/Server/RNs /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB3/Client
```

- _The Server will generate SignS on the hash of RNc and RNs thanks to its private key Server-PrivKey:_

  - _Make a concatenation of RNc and RNs by entering the UNIX command:_ `cat RNc RNs > RNcRNs`

  First, we concatenate RNc and RNs in RNcRNs.

  ```sh
    cat RNc RNs > RNcRNs
    ls
    CACert.crt  RNcRNs   ServerKeyPair.key ServerPubKey

    RNc   RNs   ServerPrivKey  ServerRequest.csr

  ```

  - _Apply the hash function SHA256 on RNcRNs to find its hash HashRNcRNs._

  Then, we hash it using sha256.

  ```sh
    openssl dgst -sha256 -out HashRNcRNs RNcRNs
  ```

- _We ask you to proceed to generate SignS thanks to ServerPrivKey._

  We generated SignS thanks to the server private key and the Hash of RNc and RNs

  ```sh
    openssl rsautl -sign -in HashRNcRNs -inkey ServerPrivKey -out SignS
  ```

- _You can send now SignS and ServerCert.crt to the Client._

  ```sh
    cp SignS /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB3/Client
    cp ServerCert.crt /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB3/Client
  ```

- _The Client needs to verify ServerCert.crt. We ask you to verify it as you did in the last session._

  ```sh
    openssl verify -CAfile CACert.crt ServerCert.crt
  ```

- _The Client needs to verify SignS. We ask you to verify it as follows:_

  - _Extract ServerPubKey from ServerCert.crt_

  First, we extract the server public key from the certificate using x509 and we store in ServerPubKey.

  ```sh
  openssl x509 -pubkey -noout -in ServerCert.crt  > ServerPubKey
  ```

  - _Repeat the same steps to verify a signature as you did in part 5 of Exercise 2 in LAB1_

    ```sh
    openssl rsautl -verify -in SignS -pubin -inkey ServerPubKey -out HashAuthData
    openssl dgst -sha256 -out Hash AuthData
    diff Hash HashAuthData

    ```

- _The Client will generate a pre-master symmetric key PMsc and sends it encrypted to the Server:_

  - _We ask you to generate PMsc._

  We generate the symetric key as we did in previous labs with rand command.

  ```sh
    openssl rand -hex -out PMsc 64
  ```

  - _Encrypt PMsc thanks to ServerPubKey by naming the encrypted symmetric key PMscEncrypted_

  We use rsault command to encrypt PMsc, we store it in PMscEncrypted.

  ```sh
  openssl rsautl -encrypt -inkey ServerPubKey -pubin -in PMsc -out PMscEncrypted

  ```

  - _Send PMscEncrypted to the Server_

  We send the file by copying it into the server folder.

  ```sh
    cp PMscEncrypted /Users/hugobeheray/Documents/ING4S2/IS\ Security/LAB3/Server
  ```

  - _Decrypt PMscEncrypted thanks to ServerPrivateKey by naming the decrypted key PMsc._

  ```sh
    openssl rsautl -decrypt -inkey ServerPrivKey -in PMscEncrypted -out PMsc
  ```

- _Both the Client and server will generate the Master Symmetric key MS which is calculated from the hash of PMsc, RNc and RNs:_

  - _We ask you to calculate MS._

  We generate MS by concatening the hash of PMsc and RNcRNs

  First, we hash PMsc:

  ```sh
    openssl dgst -sha256 -out HashPMsc PMsc
  ```

  Then we cat both hash into MS.

  ```sh
    cat HashRNcRNs HashPMsc > MS
  ```

  We do this Client and Server side.

  - _We ask you to create the file ClientData and encrypt it thanks to MS._

  We wrote "Data from client" in the file.

  ```sh
    touch ClientData
    vim ClientData
    openssl enc -in ClientData -out ClientDataEnc -e -des-cbc -k MS
  ```

  - _Send the encrypted result to the Server and decrypt it._

  ```sh
    cp ClientDataEnc ../Server
    openssl enc -in ClientDataEnc -out ClientData  -d -des-cbc -k MS
    cat ClientData
    Data from client
  ```

  We can see that we get the previous message that we wrote Client side

- _The Server will answer to the Client:_

  - _Create the file ServerData and encrypt it thanks to MS._

  We wrote "Data from server" in the file.

  ```sh
    touch ServerData
    vim ServerData
    openssl enc -in ServerData -out ServerDataEnc -e -des-cbc -k MS
  ```

  - _Send the encrypted result to the Client and decrypt it._

  ```sh
    openssl enc -in ServerDataEnc -out ServerData  -d -des-cbc -k MS
    cat ServerData
    Data from Server
  ```

  We can see that we get the previous message that we wrote Server side
