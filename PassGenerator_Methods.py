import random

stringOfCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
stringOfSmall = "abcdefghijklmnopqrstuvwxyz"
stringOfNum = "1234567890"
stringOfSpecial = "!@#$%^&*()_+={[}]':;><?/"

def CheckCharacters(password, length):

    index = 0    
    containsCap = 0
    containsSmall = 0
    containsNum = 0
    containsSpec = 0

    #loop for checking if the letter from a category exists or not.
    while(True):
        
        if(stringOfCaps.find(password[index]) != -1):
            containsCap = 1
        if(stringOfSmall.find(password[index]) != -1):
            containsSmall = 1
        if(stringOfNum.find(password[index]) != -1):
            containsNum = 1
        if(stringOfSpecial.find(password[index]) != -1):
            containsSpec = 1
                           
        if(index == length - 1):
            break

        index = index + 1 

    #putting a character from a category at the end of the generated password if the generated password doesn't contain a character from that category.
    if(containsCap == 0):
        password = password + random.choice(stringOfCaps)
    if(containsSmall == 0):
        password = password + random.choice(stringOfSmall)
    if(containsNum == 0):
        password = password + random.choice(stringOfNum)
    if(containsSpec == 0):
        password = password + random.choice(stringOfSpecial)
            
    return password


def newPassword():
    #setting up variables
    newPassword = ""
    preiviousDecision = 0
    length = 0
        
    #main loop and generating a password
    while(True):
        
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
        length = length + 1
        preiviousDecision = decision

        #stopping        
        stop = random.randint(0, 2)
        if (length >= 8 and stop == 2):
            break    
    
    newPassword = CheckCharacters(newPassword, len(newPassword))    

    return newPassword
