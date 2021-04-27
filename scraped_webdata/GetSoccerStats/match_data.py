from bs4 import BeautifulSoup
from string import ascii_uppercase
import requests
from csv import writer
import random




from bs4 import BeautifulSoup
from string import ascii_uppercase
import requests
from csv import writer
import csv
import unicodedata
import sys

lines = []
with open('Teams.txt') as f:
    lines = [line.rstrip('\n') for line in f]

text_file = open("Players.txt", "r+", encoding="utf-8")

# players = []
# for i in range(0, len(lines)-1):
#     r = requests.get(lines[i])
#     soup = BeautifulSoup(r.content, "html.parser")
#     roster_table = soup.find('tbody')
#     x = roster_table.findAll('th')
#     for stuff in x:
#         name_a = stuff.find('a')['href']
#         t_url = 'https://fbref.com' + name_a
#         #name_link = name_a['href']
#         if name_a not in players:
#             players.append(name_a)
#             text_file.writelines('{}\n'.format(t_url))
#             print(name_a)
# text_file.close()

list_of_elem = ['Name', 'PlayerID', 'Position', 'Height', 'Weight', 'Born']
with open('players.csv', 'a+', newline='', encoding='utf-8') as write_obj:
    # Create a writer object from csv module
    csv_writer = writer(write_obj)
    # Add contents of list as last row in the csv file
    csv_writer.writerow(list_of_elem)

player_Dict = {}

lines = []
with open('Players.txt') as f:
    lines = [line.rstrip('\n') for line in f]

position = ''
name = ''
height = ''
weight = ''
birth = ''
playerID = 0
for i in range(0, len(lines)-1):
    playerID += 1
    r = requests.get(lines[i])
    soup = BeautifulSoup(r.content, "html.parser")
    name_h1 = soup.find('h1', {'itemprop': 'name'})
    if(name_h1 is None) :
        break
    name = name_h1.find('span').text.encode('ascii', 'ignore').decode('ascii')
    print(name)
    player_div = soup.find('div', {'itemtype': 'https://schema.org/Person'})
    nextNode = player_div.h1
    weight_counter = 0
    birth_counter = 0
    height_counter = 0
    position_counter = 0
    if(i == 1): continue
    while nextNode != None:
        nextNode = nextNode.nextSibling
        if(nextNode == 'h1'): continue
        if(nextNode == '\n'): continue
        if(nextNode == 'script'): continue
        if(nextNode is None): break
        try:
            if(nextNode.strong):
                if(nextNode.strong.text == 'Position:'):
                    position_list = nextNode.text.replace('\xa0',' ').split(" ")
                    if (len(position_list) > 1):
                        position = position_list[1]
                    else:
                        position = position_list[0]
                    print(position)
                    position_counter += 1
                if(nextNode.strong.text == 'Born:'):
                    born = nextNode.span.text.strip()
                    print(born)
                    birth_counter += 1
            elif(nextNode.name == 'p'):
                children = nextNode.findAll('span')
                for child in children:
                    if child['itemprop'] == 'height':
                        height = child.text.replace("cm", '')
                        print(height)
                        height_counter += 1
                    if child['itemprop'] == 'weight':
                        weight = child.text.replace("kg", '')
                        print(weight)
                        weight_counter += 1
            else:
                continue
        except:
            print(sys.exc_info()[0])
    player_Dict[name] = playerID
    if position_counter == 0: position = None
    if birth_counter == 0: born = None
    if height_counter == 0: height = None
    if weight_counter == 0: weight = None
    list_of_elem = [name, playerID, position, height, weight, born]
    with open('players.csv', 'a+', newline='', encoding='utf-8') as write_obj:
        # Create a writer object from csv module
        csv_writer = writer(write_obj, quoting =csv.QUOTE_MINIMAL)
        # Add contents of list as last row in the csv file
        csv_writer.writerow(list_of_elem)






teamLines = []
with open('Teams.txt') as f:
    teamLines = [line.rstrip('\n') for line in f]
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
for i in range(0, len(teamLines)):
    
    r = requests.get(teamLines[i])
    soup = BeautifulSoup(r.content, "html.parser")
    name_h1 = soup.find('h1', {"itemprop": "name"})
    if(name_h1 is None) :
        break
    name = name_h1.find('span').text.encode('ascii', 'ignore').decode('ascii')
    name_list = name.split(' ')
    team_name = ''
    for i in range(1, len(name_list)-1):
        if(i < 2):
            team_name += name_list[i]
        else:
            team_name += " {}".format(name_list[i])
        
    if team_name not in list_of_teams:
        TeamId += 1
        TeamDict[team_name] = TeamId
        list_of_teams.append(team_name)
        list_of_elem = [TeamId, team_name]
        with open('team_data.csv', 'a+', newline='', encoding='utf-8') as write_obj:
            # Create a writer object from csv module
            csv_writer = writer(write_obj)
            # Add contents of list as last row in the csv file
            csv_writer.writerow(list_of_elem)



other_lines = []
with open('WorldCup_matches.txt') as f:
    other_lines = [line.rstrip('\n') for line in f]



StadiumID = 0
stadiumDict = {}
for i in range(0, len(other_lines)-1):
    r = requests.get(other_lines[i])
    soup = BeautifulSoup(r.content, "html.parser")
    scorebox_div = soup.find('div', {"class": "scorebox"})

    scorebox_meta = scorebox_div.find('div', {'class': "scorebox_meta"})

    buncha_divs = scorebox_meta.findAll('div')

    venue_div = buncha_divs[5]

    smalls = venue_div.findAll('small')
    smally = smalls[1].text.encode('ascii', 'ignore').decode('ascii')
    s = smally.replace("  (Neutral Site)", "")
    sep = ','
    stripped = s.split(sep, 1)[0]
    Name = stripped

    if Name not in stadiumDict.keys():
        Capacity = random.randint(44000,100000)
        StadiumID += 1
        list_of_elem = [StadiumID, Name, Capacity]
        stadiumDict[Name] = StadiumID
        print(StadiumID)
        with open('venue.csv', 'a+', newline='', encoding='utf-8') as write_obj:
            # Create a writer object from csv module
            csv_writer = writer(write_obj)
            # Add contents of list as last row in the csv file
            csv_writer.writerow(list_of_elem)






matchestext = open("matchesdata.txt", "r+", encoding="utf-8")




lines = []
with open('WorldCup_matches.txt') as f:
    lines = [line.rstrip('\n') for line in f]
Stage = ""
match_dict = {}
list_of_elem = ['TournamentID', 'MatchID', 'Team_a', 'Team_b', 'GameDate', 'Attendence', 'Venue', 'Stage']
with open('match_data.csv', 'a+', newline='') as write_obj:
    # Create a writer object from csv module
    csv_writer = writer(write_obj)
    # Add contents of list as last row in the csv file
    csv_writer.writerow(list_of_elem)
match_ID = 0
for i in range(0, len(lines)-1):
    match_ID += 1
    r = requests.get(lines[i])
    soup = BeautifulSoup(r.content, "html.parser")
    scorebox_div = soup.find('div', {"class": "scorebox"})
    teams = scorebox_div.findAll('div', {"itemprop": 'performer'})
    count = 0
    Team_a = ''
    Team_b = ''
    for team in teams:
        if count == 0: 
            Team_a = team.find('a').text.encode('ascii', 'ignore').decode('ascii')
        else:
            Team_b = team.find('a').text.encode('ascii', 'ignore').decode('ascii')
        count += 1
    scorebox_meta = scorebox_div.find('div', {'class': "scorebox_meta"})

    href = soup.find('head').findAll('link')[1]['href']
    print(href)
    

    GameDate = scorebox_meta.find('a').text
    buncha_divs = scorebox_meta.findAll('div')
    attendence_div = buncha_divs[4]


    stage_div = buncha_divs[1]

    s = stage_div.text.replace("FIFA World Cup ", "")
    Stage = s.strip("()")
    venue_div = buncha_divs[5]
    smalls = attendence_div.findAll('small')
    if(len(smalls) == 0):
        Attendence = 0
    else:
        Attendence = int(smalls[1].text.replace(",", ""))
    smalls = venue_div.findAll('small')
    smally = smalls[1].text.encode('ascii', 'ignore').decode('ascii')
    s = smally.replace("  (Neutral Site)", "")
    sep = ','
    stripped = s.split(sep, 1)[0]
    Venue = stripped
    num = int(GameDate.split(" ")[3])
    mynum = num - 1986
    print(mynum)
    
    list_of_elem = [mynum, match_ID, TeamDict[Team_a], TeamDict[Team_b], GameDate, Attendence, stadiumDict[Venue], Stage]
    match_dict[match_ID] = [str(TeamDict[Team_a]), str(TeamDict[Team_b]), GameDate]
    matchestext.writelines(str(match_ID) + match_dict[match_ID][0] + match_dict[match_ID][1] + match_dict[match_ID][2] )
    print(GameDate)
    with open('match_data.csv', 'a+', newline='', encoding='utf-8') as write_obj:
        # Create a writer object from csv module
        csv_writer = writer(write_obj)
        # Add contents of list as last row in the csv file
        csv_writer.writerow(list_of_elem)




playerTeam= {}

for i in range(0, len(teamLines)-1):
    
    r = requests.get(teamLines[i])
    soup = BeautifulSoup(r.content, "html.parser")
    name_h1 = soup.find('h1', {'itemprop': 'name'})
    name = name_h1.find("span")
    myTeam = name.text.encode('ascii', 'ignore').decode('ascii')
    name_list = myTeam.split(' ')
    team_name = ''
    for i in range(1, len(name_list)-1):
        if(i < 2):
            team_name += name_list[i]
        else:
            team_name += " {}".format(name_list[i])


    roster = soup.findAll('table')

    rosterbody = roster[0].find('tbody')
    x = rosterbody.findAll('th')
    for stuff in x:
        print(stuff.child)
        name_a = stuff.find('a').text.encode('ascii', 'ignore').decode('ascii')
        print(name_a)
        if(name_a == 'Jos Luis Brown'): name_a = 'Jos Luis Cuciuffo'
        if(name_a not in playerTeam.keys()):
            playerTeam[player_Dict[name_a]] = TeamDict[team_name]
            list_of_elem=[player_Dict[name_a], TeamDict[team_name]]
            with open('TeamPlayer.csv', 'a+', newline='', encoding='utf-8') as write_obj:
                # Create a writer object from csv module
                csv_writer = writer(write_obj)
                # Add contents of list as last row in the csv file
                csv_writer.writerow(list_of_elem)

