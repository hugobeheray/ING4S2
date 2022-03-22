import numpy as np

stopCondition = 0.005 # Stop the program when the changes are small enough
gamma = 0.99 #discount factor

# Define states
states=[]
for i in range(3):
    for j in range(4):
            states.append((i,j))

# Define rewards
rewards = {}
for i in states:
    if i == (0,3):
        rewards[i] = 1
    elif i == (1,3):
        rewards[i] = -1
    else:
        rewards[i] = -0.2

# Define actions
actions = {
    (0,0):('S', 'E'),
    (0,1):('E', 'W'),    
    (0,2):('W', 'S', 'E'),
    (1,0):('N', 'S'),
    (1,2):('N', 'S', 'E'),
    (2,0):('N', 'E'),
    (2,1):('E', 'W'),
    (2,2):('N', 'W', 'E'),
    (2,3):('W', 'N'),
}

# Define and initialize action-value function 
Q={}
for s in states:
    for a in actions:
        if s in actions.keys():
            Q[s][a] = -0.2
        if s ==(0,3):
            Q[s][a] = 1
        if s == (1,3):
            Q[s][a] = -1
            
#while True:
