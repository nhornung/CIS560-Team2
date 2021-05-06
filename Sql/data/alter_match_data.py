import pandas as pd
  
# reading the csv file
df = pd.read_csv("match_data.csv")
  
# updating the column value/data

for index, row in df.iterrows():
    splitGameDate = df['GameDate'].str.split(" ")
    county = 1
    for row in splitGameDate:
        new_string = ""
        count = 0
        for i in row:
            count+=1
            if count == 1:
                continue
            if count == 4:
                new_string += i
            else:
                new_string += i + " "
                #print(i)
        print(new_string)
        df.loc[county, 'GameDate'] = new_string
        df.to_csv("match_data.csv", index=False)
        county+= 1
    #print(df['GameDate'])
    

  
# # writing into the file
# #df.to_csv("match_data.csv", index=False)

# import csv
  
# op = open("match_data.csv", "r")
# dt = csv.DictReader(op)
# print(dt)
# up_dt = []
# splitGameDate = str(df['GameDate']).split(" ")
# print(df['GameDate'])
# new_string = ""
# count = 0
# for string in splitGameDate:
#     count+=1
#     if count == 1:
#         break
#     if count == 4:
#         new_string.append(string)
#     else:
#         new_string.append(string + " ")
# for r in dt:
#     print(r)
#     row = {'TeamID': r['TeamID'],
#            'StadiumID': r['StadiumID'],
#            'TournamentID': r['TournamentID'],
#            'TeamA': r['TeamA'],
#            'TeamB': r['TeamB'],
#            'GameDate': r['GameDate'],
#            'TournamentStage': r['TournamentStage'],
#            'Attendance': r['Attendance']}
#     up_dt.append(row)
# print(up_dt)
# op.close()
# op = open("match_data.csv", "w", newline='')
# headers = ['TeamID', 'StadiumID', 'TournamentID', 'TeamA', 'TeamB', 'GameDate', 'TournamentStage', 'Attendance']
# data = csv.DictWriter(op, delimiter=',', fieldnames=headers)
# data.writerow(dict((heads, heads) for heads in headers))
# data.writerows(up_dt)
  
# op.close()
  
