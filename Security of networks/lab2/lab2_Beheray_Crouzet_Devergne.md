# Lab2 

#### Part 1. 

###### Step1.

![image-20220114131109111](C:\Users\noemi\ReseauS2\lab2\image-20220114131109111.png)

![image-20220114131136810](C:\Users\noemi\ReseauS2\lab2\image-20220114131136810.png)

![image-20220114131158478](C:\Users\noemi\ReseauS2\lab2\image-20220114131158478.png)

###### Step 2

![image-20220114132213323](C:\Users\noemi\ReseauS2\lab2\image-20220114132213323.png)

![image-20220114132238739](C:\Users\noemi\ReseauS2\lab2\image-20220114132238739.png)

###### Step 3

![image-20220114132553582](C:\Users\noemi\ReseauS2\lab2\image-20220114132553582.png)

The prefixe supported are disk0 and flash. 

The show flash command gives us this result : 

![image-20220114133227470](C:\Users\noemi\ReseauS2\lab2\image-20220114133227470.png)

The show disk0 command gives us this result :

![image-20220114133307406](C:\Users\noemi\ReseauS2\lab2\image-20220114133307406.png)

#### Part 2

###### Step 1. 

![image-20220114133833470](C:\Users\noemi\ReseauS2\lab2\image-20220114133833470.png)

###### Step 2. 

![image-20220114133858757](C:\Users\noemi\ReseauS2\lab2\image-20220114133858757.png)

###### Step 3. 

![image-20220114134425764](C:\Users\noemi\ReseauS2\lab2\image-20220114134425764.png)

###### Step 4.

a & b.

![image-20220114134903665](C:\Users\noemi\ReseauS2\lab2\image-20220114134903665.png)

c.

The show interface ip brief is a command to promp the status for all ASA interfaces. We can see that the two vlan we configured are up.

![image-20220114135449713](C:\Users\noemi\ReseauS2\lab2\image-20220114135449713.png)

The show ip address command is a command to display the informations for VLAN interfaces. 

![image-20220114135554721](C:\Users\noemi\ReseauS2\lab2\image-20220114135554721.png)

The show switch vlan command is a command to display the inside and outside VLANs configured on the ASA and to display the assigned ports. 

![image-20220114135957138](C:\Users\noemi\ReseauS2\lab2\image-20220114135957138.png)

###### Step 5. 

We are able to ping from PC B to the ASA. 

![image-20220114140118294](C:\Users\noemi\ReseauS2\lab2\image-20220114140118294.png)

We are not able to ping the VLAN 2 from the PC B. 

![image-20220114140309403](C:\Users\noemi\ReseauS2\lab2\image-20220114140309403.png)

#### Part 3. 

###### Step 1. 

![image-20220114144458991](C:\Users\noemi\ReseauS2\lab2\image-20220114144458991.png)

The ASA can ping the R1 S0/0/0 Ip address. 

![image-20220114144627341](C:\Users\noemi\ReseauS2\lab2\image-20220114144627341.png)

###### Step 2. 

![image-20220114144822799](C:\Users\noemi\ReseauS2\lab2\image-20220114144822799.png)

The show run commands displays this result: 

![image-20220114145016487](C:\Users\noemi\ReseauS2\lab2\image-20220114145016487.png)

We are not allowed to ping the R1 G0/0 interface from PC C. 

![image-20220114145157183](C:\Users\noemi\ReseauS2\lab2\image-20220114145157183.png)

The show nat command shows this result:

![image-20220114145930810](C:\Users\noemi\ReseauS2\lab2\image-20220114145930810.png)

###### Step 3. 

![image-20220114150304303](C:\Users\noemi\ReseauS2\lab2\image-20220114150304303.png)

The ping is successful. 

![image-20220114150354242](C:\Users\noemi\ReseauS2\lab2\image-20220114150354242.png)

#### Part 4. 

###### Step 1. 

![image-20220114150555435](C:\Users\noemi\ReseauS2\lab2\image-20220114150555435.png)

###### Step 2. 

![image-20220114151153586](C:\Users\noemi\ReseauS2\lab2\image-20220114151153586.png)

###### Step 3.

![image-20220114151421211](C:\Users\noemi\ReseauS2\lab2\image-20220114151421211.png)

From PC-C, we can establish an SSH session to the ASA. 

![image-20220114151549629](C:\Users\noemi\ReseauS2\lab2\image-20220114151549629.png)

From the PC-B, we can also establish a SSH session to the ASA.

![image-20220114151653167](C:\Users\noemi\ReseauS2\lab2\image-20220114151653167.png)

#### Part 5. 

###### Step 1.

![image-20220114152104240](C:\Users\noemi\ReseauS2\lab2\image-20220114152104240.png)

The show interface ip brief displayes these informations: 

![image-20220114152159006](C:\Users\noemi\ReseauS2\lab2\image-20220114152159006.png)

The show ip address displayes these informations:

![image-20220114152242178](C:\Users\noemi\ReseauS2\lab2\image-20220114152242178.png)

The show switch vlan displayes these informations:

![image-20220114152350433](C:\Users\noemi\ReseauS2\lab2\image-20220114152350433.png)

###### Step 3. 

![image-20220114152644627](C:\Users\noemi\ReseauS2\lab2\image-20220114152644627.png)

###### Step 5. 

![image-20220114153407345](C:\Users\noemi\ReseauS2\lab2\image-20220114153407345.png)

This is the items that we are not able to complete. 



##### Questions: 

1. NAT is a very important aspect of firewall security. It conserves the number of public addresses used within an organization, and it allows for stricter control of access to resources on both sides of the firewall.

   

2. A DMZ network provides access control to services outside an organization's network perimeters that are accessed from the internet.

   A DMZ also prevents an attacker from being able to scope out potential targets within the network.

   In some cases, attackers attempt to bypass access control restrictions byspoofing an authorized IP address to impersonate another device on the network. A DMZ can stall potential IP spoofers, while another service on the network verifies the IP address's legitimacy by testing whether it is reachable.