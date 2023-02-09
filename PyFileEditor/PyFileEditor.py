import this


text = open('TextFile1.txt', 'r+')
lines = text.readlines()
lines[0] = "Today date is " + lines[0]
lines[1] = "Random number is " + lines[1]
lines[2] = "Random Bloodborne boss is " + lines[2]
text.close()
open('TextFile1.txt', 'w').close()

file = open('TextFile1.txt', 'r+')
for line in lines:
    file.write(line)
file.close()

# quit()