from bs4 import BeautifulSoup
from string import ascii_uppercase
import requests
from csv import writer







lines = []
with open('Teams.txt') as f:
    lines = [line.rstrip('\n') for line in f]
TeamDict = {}
TeamId = 0
list_of_elem = ['TeamID', 'Nation']
# with open('match_data.csv', 'a+', newline='') as write_obj:
#     # Create a writer object from csv module
#     csv_writer = writer(write_obj)
#     # Add contents of list as last row in the csv file
#     csv_writer.writerow(list_of_elem)

with open('team_data.csv', 'a+', newline='') as write_obj:
    # Create a writer object from csv module
    csv_writer = writer(write_obj)
    # Add contents of list as last row in the csv file
    csv_writer.writerow(list_of_elem)

list_of_teams = []
for i in range(0, len(lines)-1):
    TeamId += 1
    r = requests.get(lines[i])
    soup = BeautifulSoup(r.content, "html.parser")
    name_h1 = soup.find('h1', {"itemprop": "name"})
    name = name_h1.find("span").text
    name_list = name.split(' ')
    team_name = ''
    for i in range(1, len(name_list)-1):
        if(i < 2):
            team_name += name_list[i]
        else:
            team_name += " {}".format(name_list[i])
        
    if team_name not in list_of_teams:
        TeamDict[TeamId] = team_name
        list_of_teams.append(team_name)
        list_of_elem = [TeamId, team_name]
        with open('team_data.csv', 'a+', newline='', encoding='utf-8') as write_obj:
            # Create a writer object from csv module
            csv_writer = writer(write_obj)
            # Add contents of list as last row in the csv file
            csv_writer.writerow(list_of_elem)
