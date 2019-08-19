import sqlite3
import requests



html = requests.get('https://www.hack520.com/666.html')

print(html.text)

'''
conn = sqlite3.connect('itemBank.db')
cursor = conn.cursor()
cursor.execute('create table qiangguo(id int primary key, question text)')
'''
