import csv

with open('players.csv') as csv_file:
    playerID = []
    csv_reader = csv.reader(csv_file, delimiter=',')
    line_count = 0
    for row in csv_reader:
        if line_count == 0:
            break
        else:
            playerID.append(row[0])
            line_count += 1

    