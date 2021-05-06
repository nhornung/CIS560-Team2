import random
from datetime import datetime, timezone
import numpy as np
from csv import writer


def random_date(seed):
    random.seed(seed)
    d = random.randint(1, int(time.time()))
    return datetime.fromtimestamp(d)

print("Hello")
import csv
import time
playerID = []
with open('players.csv') as csv_file:
    csv_reader = csv.reader(csv_file, delimiter=',')
    header = next(csv_reader)
    line_count = 0
    for row in csv_reader:

        playerID.append(row[1])
        line_count += 1
for row in playerID:
    print(row)

TeamID = []
with open('team_data.csv') as csv_file:
    csv_reader = csv.reader(csv_file, delimiter=',')
    header = next(csv_reader)
    line_count = 0
    for row in csv_reader:

        TeamID.append(row[0])
        line_count += 1
for row in TeamID:
    print(row)



Team_player = ['', '', '', '']
count= 0
count2 = 5000
for row in playerID:
    count += 1
    count2 += 1
    StartDate = random_date(count).strftime('%Y-%m-%d')
    EndDate = random_date(count2).strftime('%Y-%m-%d')
    print(StartDate)


    team = random.choice(TeamID)
    list_of_elem = [team, row, StartDate, EndDate]
    with open('TeamPlayer.csv', 'a+', newline='', encoding='utf-8') as write_obj:
                # Create a writer object from csv module
                csv_writer = writer(write_obj)
                # Add contents of list as last row in the csv file
                csv_writer.writerow(list_of_elem)


    