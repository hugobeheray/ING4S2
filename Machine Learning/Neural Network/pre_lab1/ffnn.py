# Implement the forward propagation of a feedforward neural network (FFNN) consisting of
# three layers, in which the hidden layer has K neurons (at your choice). Remember you need
# to arrive to show the error results (i.e., define X, X, V , X, F, F, W, F, G, and E)

# We chose 5 neurons in the hidden layer


import numpy as np
import math
import matplotlib.pyplot as plt

N = 2   # number of features (columns)
I = 71  # number of input (rows)
K = 5   # number of neurons in hidden layer
J = 3   # number of output neurons (possible prediction)
alpha = 0.01

# we load data and only keep features
data = np.loadtxt("data_ffnn_3classes.txt", dtype=float)
X = np.delete(data, N, axis=1)

# we create X_ adding 1 to each row to create the bias value
biais = np.ones((I,1))
X_ = np.concatenate((biais,X), axis =1)

# we create V with random values for the weights
V = np.random.rand(N+1,K) *.01

# we multiply the value of the input with the weight
X__ = np.dot(X_,V)


# FIRST LAYER :

# activation : we measure how relevant each values is
# we create and fill F : F are values between 0 and 1 thanks to the sygmoide function
F = np.zeros((I, K))
for i in range (I):
    for j in range(K):
        F[i][j] = 1 + math.exp(-X__[i][j])

F = np.reciprocal(F)


# SECOND LAYER :

# we create F_ 
F_ = np.concatenate((biais,F), axis =1)

# we create random weights
W = np.random.rand(K+1, J) *.01

# we create F__ by multiplying F_ and W
F__ = F_.dot(W)

# we create and fill G just as we did for F
G = np.zeros((I, J))
for i in range (I):
    for j in range(J):
        G[i][j] = 1 + math.exp(-F__[i][j])

G = np.reciprocal(G)


# we create Y to get 1 columns with the results normalized
Y = np.zeros((I,1))


Y = np.zeros((71, 3))
for i in range(71):
    if (data[i][2] == 0):
        Y[i][0] = 1
    elif (data[i][2] == 1):
        Y[i][1] = 1
    elif (data[i][2] == 2):
        Y[i][2] = 1


# ERROR :

E = 0

for i in range (I):
    for j in range(J):
        E = E + math.pow(Y[i][j] - G[i][j], 2)

E = E*0.5

print("Error : ",E)


# PLOT :

colors = [row[2] for row in data]

plt.scatter([row[0] for row in data],[row[1] for row in data], c=colors)

plt.xlabel('feature 1')
plt.ylabel('feature 2')
plt.show()