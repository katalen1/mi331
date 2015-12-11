import sqlite3

conn = sqlite3.connect("database.sqlite")

def addRecord():
    nameString = raw_input("What is your name?: ")
    scoreString = raw_input("What was your score?: ")
    matchesString = raw_input("How many matches have you played?: ")
    score = int(scoreString)
    matches = int(matchesString)
    conn.execute('insert into entries (name, score, matches) values(?, ?, ?)', [nameString, score, matches])
    conn.commit()


def leaderboardPrint():
    print "==== MI331 Leaderboard ===="
    result = conn.execute('SELECT * FROM entries ORDER BY score DESC ')
    for tuple in result:
        print tuple[0] + "\t" + str(tuple[1]) + "\t" + str(tuple[2])

def leaderboardNamePrint():
    print "==== MI331 Leaderboard ===="
    result = conn.execute('SELECT * FROM entries ORDER BY name ')
    for tuple in result:
        print tuple[0] + "\t" + str(tuple[1]) + "\t" + str(tuple[2])

def leaderboardMatchesPrint():
    print "==== MI331 Leaderboard ===="
    result = conn.execute('SELECT * FROM entries ORDER BY matches DESC ')
    for tuple in result:
        print tuple[0] + "\t" + str(tuple[1]) + "\t" + str(tuple[2])

def deleteRecord():
    nameString = raw_input("Which record(name) do you want to delete?: ")
    conn.execute('DELETE from entries WHERE name=?', [nameString])
    conn.commit()

def deleteRecordMinScore():
    scoreMin = raw_input("Please enter the minimum score, all records with scores below this will be deleted: ")
    minScore = int(scoreMin)
    conn.execute('DELETE FROM entries WHERE score<?', [minScore])
    conn.commit()

while(True):
    print("")
    print ("What would you like to do?")
    print (" 1. Add a new record")
    print (" 2. Print Scoreboard - sort by score (high-to-low)")
    print (" 3. Print Scoreboard - sort by name (A-Z)")
    print (" 4. Print Scoreboard - sort by matches played (high-to-low)")
    print (" 5. Delete record by name")
    print (" 6. Delete all scores under a minimum")
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
    elif choice =='5':
        deleteRecord()
    elif choice =='6':
        deleteRecordMinScore()
    elif choice=='x':
        break
    else:
        print ">> undefined!"