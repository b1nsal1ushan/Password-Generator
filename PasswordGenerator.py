import random

#setting up variables
newPassword = ""
previousCharacter = ""
length = 0

#setting up strings
stringOfCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
stringOfSmall = "abcdefghijklmnopqrstuvwxyz"
stringOfNum = "1234567890"
stringOfSpecial = "!@#$%^&*()_+={[}]':;><?/"

#main loop and generating a password
while(True):

    #taking everycharacter randomly    
    capCharacter = random.choice(stringOfCaps)
    smallCharacter = random.choice(stringOfSmall)
    Num = random.choice(stringOfNum)
    special = random.choice(stringOfSpecial)

    #sub-loop of putting character and making sure it's not previously used and it contain every character
    while(True):

        #taking a random from the strings
        decision = random.randint(1, 4)
        if (decision == 1):
            currentCharacter = random.choice(stringOfCaps)
        elif (decision == 2):
            currentCharacter = random.choice(stringOfSmall)
        elif (decision == 3):
            currentCharacter = random.choice(stringOfNum)
        elif (decision == 4):
            currentCharacter = random.choice(stringOfSpecial)

        #checking if it is in the passowrd or not. Also checking it doesn't repeat
        if (previousCharacter != currentCharacter and newPassword.find(currentCharacter) == -1):
            break

    #putting characters together
    newPassword = newPassword + currentCharacter
    length = length + 1
    previousCharacter = currentCharacter

    #stopping if it is more than 8
    stop = random.randint(0, 2)
    if (length >= 8 and stop == 2):
        break    
    
#New Password!!
print(newPassword)
