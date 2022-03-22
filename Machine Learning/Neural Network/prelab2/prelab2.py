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
        rewards[i] = -0.02

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

# Define and initialize policy with random numbers for each action
policy={}
for s in actions.keys():
    policy[s] = np.random.choice(actions[s])

# Define and initialize value function 
V={}
for s in states:
    if s in actions.keys():
        V[s] = -0.02
    if s ==(0,3):
        V[s] = 1
    if s == (1,3):
        V[s] = -1


while True:
    biggestChange = 0
    for s in states:
        if s in policy:
            
            # Keep old value function
            oldV = V[s]
            newV = 0
            
            # Plan next move of the robot depending on the direction
            for a in actions[s]:
                if a == 'N':
                    next = [s[0]-1, s[1]]
                elif a == 'S':
                    next = [s[0]+1, s[1]]
                elif a == 'E':
                    next = [s[0], s[1]+1]
                else:
                    next = [s[0], s[1]-1]

                # Choose a new random action to do
                random = np.random.choice([i for i in actions[s] if i != a])
                if random == 'N':
                    act = [s[0]-1, s[1]]
                elif random == 'S':
                    act = [s[0]+1, s[1]]
                elif random == 'E':
                    act = [s[0], s[1]+1]
                else:
                    act = [s[0], s[1]-1]

                # Calculate the value
                next = tuple(next)
                act = tuple(act)
                v = rewards[s] + (gamma * ((0.8)* V[next] + (0.1 * V[act]) + (0.1 * V[act])))
                if v > newV:
                    newV = v
                    policy[s] = a

         # Save the best of all actions for the state
        V[s] = newV
        biggestChange = max(biggestChange, np.abs(oldV - V[s]))
         
   # See if the loop should stop now         
    if biggestChange < stopCondition:
        break

print(policy)
print(V)