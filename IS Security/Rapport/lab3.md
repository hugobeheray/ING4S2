# LAB3

---

## Authors

- Hugo BEHERAY
- Zoé CROUZET

---

### Exercise "Preparation of cryptographic security elements for each actor"

- _The CARoot has a key pair CAPubKey and CAPrivKey and a self-signed certificate CACert.crt. We ask you to generate for CARoot these cryptographic security elements_

For the Private and Public keys:

```sh
openssl genrsa -out CaKeyPair
openssl rsa -in CaKEY -pubout -out CAPubKey
mv CaKEY CAPrivKey
ls
CAPrivKey CAPubKey
```

For the self-signed certificate:

```sh
openssl genrsa -out CaKeyPair -passout pass:password 4096
openssl req -x509 -new -key CAKeyPair -out CACert.crt -days 500
ls
CACert.crt  CAPrivKey   CAPubKey   CaKeyPair
```

- _The Server has also a key pair ServerPubKey and ServerPrivKey. We ask you to generate for the Server these cryptographic security elements._

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

```sh

```

- _CARoot will also send CACert.crt to the Server and the Client. Consequently, The Server and Client store CACert.crt as a Trusted Third Party. We ask you to send CACert.crt to the Server and the Client._

```sh

```

### Exercise "TLS Protocol"

- _The Client generates a file RNc. We ask you to create RNc and write a random number of your choice. Afterwards, you need to send it to the Server (by using the copy command as we have seen in the last session)_

```sh

```

- _The Server generates a  le RNs. We ask you to create RNs and write a random number of your choice. Afterwards, you need to send it to the Client_

```sh

```

- _The Server will generate SignS on the hash of RNc and RNs thanks to its private key Server-PrivKey:_

  - _Make a concatenation of RNc and RNs by entering the UNIX command: cat RNc RNs > RNcRNs._

  ```sh

  ```

  - _Apply the hash function SHA256 on RNcRNs to find its hash HashRNcRNs._

  ```sh

  ```

  - _We ask you to proceed to generate SignS thanks to ServerPrivKey._

  ```sh

  ```

  - _You can send now SignS and ServerCert.crt to the Client._

  ```sh

  ```

  - _The Client needs to verify ServerCert.crt. We ask you to verify it as you did in the last session._

  ```sh

  ```

  - _The Client needs to verify SignS. We ask you to verify it as follows:_

    - _Extract ServerPubKey from ServerCert.crt_

    ```sh

    ```

    - _Repeat the same steps to verify a signature as you did in part 5 of Exercise 2 in LAB1_

    ```sh

    ```

- _The Client will generate a pre-master symmetric key PMsc and sends it encrypted to the Server:_

  - _We ask you to generate PMsc._

  ```sh

  ```

  - _Encrypt PMsc thanks to ServerPubKey by naming the encrypted symmetric key PMscEncrypted_

  ```sh

  ```

  - _Send PMscEncrypted to the Server_

  ```sh

  ```

  - _Decrypt PMscEncrypted thanks to ServerPrivateKey by naming the decrypted key PMsc._

  ```sh

  ```

- _Both the Client and server will generate the Master Symmetric key MS which is calculated from the hash of PMsc, RNc and RNs:_

  - _We ask you to calculate MS._

  ```sh

  ```

  - _We ask you to create the file ClientData and encrypt it thanks to MS._

  ```sh

  ```

  - _Send the encrypted result to the Server and decrypt it._

  ```sh

  ```

- _The Server will answer to the Client:_

  - _Create the file ServerData and encrypt it thanks to MS._

  ```sh

  ```

  - _Send the encrypted result to the Client and decrypt it._

  ```sh

  ```
