data = [("Bob", 38200, 9), ("Alice", 25200, 11), ("Chloe", 41200, 3)]

data.append(("Keith", 10300, 6))

def sortByScore(tuple):
    return tuple[1]

def leaderboardPrint():
    sortedData = sorted(data, key=sortByScore, reverse=True)
    print"==== MI331 Leaderboard ===="
    for tuple in sortedData:
        print tuple[0] + "\t" + str(tuple[1]) + "\t" + str(tuple[2])

def addRecord():
    nameString = raw_input("What's your name?: ")
    scoreString = raw_input("What was your score?: ")
    matchesPlayed = raw_input("How many matches did you play?: ")
    score = int (scoreString)
    matches = int (matchesPlayed)
    data.append((nameString,score, matches))

def sortByName(tuple):
    return tuple[0]

def leaderboardNamePrint():
    nameSorted = sorted(data, key=sortByName)
    print"==== MI331 Leaderboard ===="
    for tuple in nameSorted:
        print tuple[0] + "\t" + str(tuple[1]) + "\t" + str(tuple[2])

def sortByMatches(tuple):
    return tuple[2]

def leaderboardMatchesPrint():
    matchesSort = sorted(data, key=sortByMatches, reverse=True)
    print"==== MI331 Leaderboard ===="
    for tuple in matchesSort:
        print tuple[0] + "\t" + str(tuple[1]) + "\t" + str(tuple[2])

leaderboardPrint()

while(True):
    print("")
    print ("What would you like to do?")
    print (" 1. Add a new record")
    print (" 2. Print Scoreboard - sort by score (high-to-low)")
    print (" 3. Print Scoreboard - sort by name (A-Z)")
    print (" 4. Print Scoreboard - sort by matches played (high-to-low)")
    print (" x. Quit")
    choice = raw_input("Your choice: ")

    if choice=='1':
        addRecord()
    elif choice=='2':
        leaderboardPrint()
    elif choice =='3':
        leaderboardNamePrint()
    elif choice =='4':
        leaderboardMatchesPrint()
    elif choice=='x':
        break
    else:
        print ">> undefined!"