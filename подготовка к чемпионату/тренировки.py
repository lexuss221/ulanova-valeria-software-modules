#task 1 - beautifulsoup, HTML-parsing

from bs4 import BeautifulSoup
import requests

#response = requests.get("https://realpython.github.io/fake-jobs/") #добавляем ссылочку

#soup = BeautifulSoup(response.text, "html.parser") #тут бибилотека, второй аргумент обязательно, работать будет, но не факт

#cards = soup.find_all('div', class_='card-content') #буквально "СУП НАЙЖИ ПЖ ВСЕ ДИВЫ КЛАССА КАРД-КОНТЕНТ"

#cards = cards[0] #тут из кардс выбираем первую карточку

#title = cards.find("h2", class_="title").text.strip()
#company = cards.find('h3', class_='company').text.strip()       #тут легко, создаем переменные, каждой присваием искаемый тег с определенным классом. текст стрип для очистки
#location = cards.find('p', class_='location').text.strip()

#print(title)
#print(company)
#print(location)

#NEXT ONE

#response = requests.get("https://realpython.github.io/fake-jobs/") 

#soup = BeautifulSoup(response.text, "html.parser") 

#cards = soup.find_all('div', class_='card-content') 

#vacancies = [] #создали список вакансии

#for card in cards: #вмесо cards=cards[0]

    #title = card.find("h2", class_="title").text.strip()
    #company = card.find('h3', class_='company').text.strip()       #тоже самое
    #location = card.find('p', class_='location').text.strip()

    #vacancy = {'title': title, 'company': company, 'location': location} #мы создали СЛОВАРЬ vacancy

    #vacancies.append(vacancy) #мы добавили словарь в список с помощью append

#print(f"Собрано вакансий: {len(vacancies)}")

####### CONTINUE ###########

#python_jobs = []

#for vac in vacancies:

    #if "python" in vac["title"].lower():
       # python_jobs.append(vac)

#print(len(python_jobs))

##### another one ######

#response = requests.get("https://realpython.github.io/fake-jobs/")
#soup = BeautifulSoup(response.text, 'html.parser')

#cards = soup.find_all('div', class_='card-content')

#location_list = []

#for card in cards:

    #location = card.find('p', class_='location').text.strip()

    #if location not in location_list:

        #location_list.append(location)

#print(f'уникальные города: {location_list}')

######### another one ##########

response = requests.get("https://realpython.github.io/fake-jobs/")
soup = BeautifulSoup(response.text, 'html.parser')

cards = soup.find_all('div', class_='card-content')

links = []

for card in cards:

    apply_link = card.find('a', string = 'Apply') #мы ищем ссылку, но не по классу, а по ТЕКСТУ в ней

    url = apply_link['href'] #дает значение атрибута href (буквально ссылку выведет, если поставить например class, то выведет класс)

    links.append(url)

print(links[0]) #выводим первую ссылку


