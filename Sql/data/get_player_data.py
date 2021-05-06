from bs4 import BeautifulSoup
from string import ascii_uppercase
import requests
from csv import writer
import csv
import unicodedata
import sys

player_dict= {}

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
text_file.close()

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
    player_dict[name] = playerID
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

