import random
#declaring variables
newPassword = ""
length = 0
stringOfCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!_@#$%^&*()<>?:"
#loops
while(True):
#character loop to make sure it doesn't repeat
    while(True):
        currentCharacter = random.choice(stringOfCharacters)
        if (newPassword.find(currentCharacter) == -1):
            break
#putting that character in the password
    newPassword = newPassword + currentCharacter    
    length = length + 1
#checking the length, making sure it's more than 8
    stop = random.randint(0, 2)
    if (length >= 8 and stop == 2):
        break    
#New Password!!
print("New password is "+newPassword)
input()