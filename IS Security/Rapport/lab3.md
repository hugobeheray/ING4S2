# LAB3

## Exercise "Preparation of cryptographic security elements for each actor"

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

- _The Server has also a key pair ServerPubKey and ServerPrivKey. We ask you to generate
  for the Server these cryptographic security elements_

```sh
cd Server/
openssl genrsa -out ServerKeyPair
openssl rsa -in ServerKeyPair  -pubout -out ServerPubKey
mv ServerKeyPair ServerPrivKey
ls
ServerPrivKey   ServerPubKey
```

- _The Client does not have any key._

- _The Server needs to create a request for a certificate ServerRequest.csr. Afterwards, it will
  send this request to CARoot. We ask you to create for the Server ServerRequest.csr and
  send it to CARoot (by using the copy command as we have seen in the last session)._

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

- _CARoot will generate ServerCert.crt and send it to the Server. We ask you to generate
  ServerCert.crt and send it to the Server_
