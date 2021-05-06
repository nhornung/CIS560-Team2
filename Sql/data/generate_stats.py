import random
from datetime import datetime, timezone
import numpy as np
from csv import writer

stats = [1, 1, 1, 1, 1,
        2, 2, 2, 2, 2, 2, 2,
        3, 3, 3, 3, 3, 3, 3, 
        4, 4, 4, 4, 4, 4, 4, 4,
        5, 5, 5, 5,
        6, 6]

print("Hello")
import csv
import time

from collections import defaultdict

team_player = defaultdict(list)

with open('TeamPlayer.csv') as csv_file:
    csv_reader = csv.reader(csv_file, delimiter=',')
    header = next(csv_reader)
    line_count = 0
    for row in csv_reader:
        team_player[row[0]].append(row[1])
        line_count += 1
count = 0

games = []
with open('match_data.csv') as csv_file:
    csv_reader = csv.reader(csv_file, delimiter=',')
    header = next(csv_reader)
    line_count = 0
    for row in csv_reader:

        games.append([row[0], row[3], row[4]])
        line_count += 1


gametime = []
for i in range(1, 90):
    gametime.append(i)

print("George")
game_player_stat = []


for row in games:
    goals = 0
    assists = 0
    player = 0
    print(row[0])
    for i in range(4, random.randrange(20, 30)):
        stat = 0
        while(True):
            stat = random.choice(stats)
            if(stat != 1 or stat != 3):
                break
            if stat == 1:
                goals += 1
            if stat == 3:
                assists += 1
            if assists == 0:
                break
            if goals > assists * 2:
                break
        rand = random.randint(1, 1000)
        if rand %  2 == 0:
            player = random.choice(team_player[row[1]])
        else:
            player = random.choice(team_player[row[2]])
        time = random.choice(gametime)
        list_of_elem = [row[0], player, stat, time]
        print(list_of_elem)
        with open('player_game_stats.csv', 'a+', newline='', encoding='utf-8') as write_obj:
                # Create a writer object from csv module
                csv_writer = writer(write_obj)
                # Add contents of list as last row in the csv file
                csv_writer.writerow(list_of_elem)
    