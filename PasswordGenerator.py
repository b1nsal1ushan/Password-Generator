import random

stringOfCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
stringOfSmall = "abcdefghijklmnopqrstuvwxyz"
stringOfNum = "1234567890"
stringOfSpecial = "!@#$%^&*()_+={[}]':;><?/"

def checkEveryCharacter(newPassword):
    checkCaps = newPassword.find(stringOfCaps)
    checkSmall = newPassword.find(stringOfSmall)
    checkNum = newPassword.find(stringOfNum)
    checkSpec = newPassword.find(stringOfSpecial)

    if (checkCaps == -1):
        newPassword = newPassword + random.choice(stringOfCaps)
    if (checkSmall == -1):
        newPassword = newPassword + random.choice(stringOfSmall)
    if (checkNum == -1):
        newPassword = newPassword + random.choice(stringOfNum)
    if (checkSpec == -1):
        newPassword = newPassword + random.choice(stringOfSpecial)

    return newPassword


def newPassword(length):
    #setting up variables
    newPassword = ""
    preiviousDecision = 0
    lengthOfPassword = 0

    #setting up strings
    

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

            #checking if it is in the passowrd or not. Also checking it chooses a different cattegory
            if (preiviousDecision != decision and newPassword.find(currentCharacter) == -1):
                break

        #putting characters together
        newPassword = newPassword + currentCharacter
        lengthOfPassword = lengthOfPassword + 1
        preiviousDecision = decision

        #stopping        
        if (lengthOfPassword == length):
            break    

    return newPassword

password = newPassword(8)
print(checkEveryCharacter(password))
