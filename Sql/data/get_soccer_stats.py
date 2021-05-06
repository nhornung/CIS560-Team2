from bs4 import BeautifulSoup
from string import ascii_uppercase
import requests


text_file = open("Output.txt", "r+", encoding="utf-8")
text_file2 = open("Teams.txt", "r+", encoding="utf-8")

list_of_pages = []
team_urls= []
match_urls = []
num = 0
for i in range(1, 20):     #Number of pages plus one
        url = "https://fbref.com/en/comps/1/{}".format(i)
        r = requests.get(url)
        soup = BeautifulSoup(r.content, "html.parser")
        header = soup.find(id='meta')
        text_file.writelines('{}\n\n'.format(header.find('h1').get_text()))
        for c in ascii_uppercase:
                if c == 'I':
                        break
                string = 'results{}1{}_overall'.format(i, c)
                text_file.writelines("GROUP  {}:\n".format(c))
                table = soup.findAll(id=string) 
                for row in table:
                        col = row.find_all('td', attrs={'data-stat' : True})
                        for c in col:
                                if c['data-stat'] == 'squad':
                                        text_file.writelines('{}\n'.format(c.text))
                                        parsed_text = c.text[3:]
                                        res = c.find('span', attrs={'title': True})
                                        if(parsed_text[0] == ' '):
                                                parsed_text = parsed_text[1:]
                                        t_url = 'https://fbref.com' + c.find('a')['href']
                                        text_file2.writelines('{}\n'.format(t_url))

# other_text_file = open("WorldCup_Matches.txt", "r+", encoding="utf-8")

# for team in team_urls:
#         r = requests.get(team)
#         soup = BeautifulSoup(r.content, "html.parser")
#         table = soup.find(id='matchlogs_for')
#         table_rows = table.findAll('tr')
#         for row in table_rows:
#                 col = row.findAll('td', attrs={'data-stat' : True})
#                 for c in col:
#                         if c['data-stat'] == 'match_report':
#                                 t_url = 'https://fbref.com' + c.find('a')['href']
#                                 if t_url in match_urls or 'WCQ' in t_url or 'ual' in t_url or 'Africa-Cup-of-Nations' in t_url:
#                                         break
#                                 match_urls.append(t_url)
#                                 print(t_url)
# for url in match_urls:
#         other_text_file.writelines('{}\n'.format(url))
# text_file.close()
# other_text_file.close()
# print("DONE")

