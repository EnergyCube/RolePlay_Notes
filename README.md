# 📝 RolePlay Notes

Do you need to take notes in your RP game?\
It's often difficult, isn't it? Well, not anymore!


## 🔨 Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## 🧾 Features
🛂 Identification and Permission System\
📦 Storage Management\
💰 Money Management\
🗃️ Information Management\
✔️ Internal Group Management\
🎭 Relationship Management\
🔍 Information Search\
💡 Custom Theme Color\
✨ API PHP (See ./web/api.php)\
✨ API C# (See ./client/RolePlay Notes/RPN_API_Web.cs)\
✨ InnoSetup Script (See ./setup)\
🍷 Working on Linux with Wine ! (With .NET Framework >= 4)


## 📖 Notes
![image](https://raw.githubusercontent.com/EnergyCube/RolePlay_Notes/main/screenshots/tek_hub.png)\
This project was developed as part of a hub project at Epitech.

## 🌐 Setup the Server

To be able to use the RolePlay Notes Client you need to install a Web Server and MariaDB, after that place files from ./web to your web server.

For Ubuntu (or Debian based)
```bash
sudo apt update
sudo apt install mariadb-server
sudo mysql_secure_installation
sudo apt install apache2
sudo apt install php
cp -R ./web [your web server folder (probably /var/www/html)]
```
After that open the PHP API (api.php)\
=> Create all tables\
=> Create a new user inside a group

## 💻Build the Client

📝 Note : You can also use the Pre-Compiled [Client Setup](https://github.com/EnergyCube/RolePlay_Notes/releases/latest).\
You will need [Visual Studio 2019](https://visualstudio.microsoft.com/vs/) and the .NET Framework 4.0\
Open the solution located at ./client, set your Server IP (don't forget HTTPS if you have it) in the C# API.\
You need to place FlatUI.dll (here is my [fork](https://github.com/EnergyCube/FlatUI/releases/latest)) in the client folder.\
Open the solution, check that you selected Release and click Build.\
After that open the application, you will have a warning, close it and open config.ini, simply put the server ip or domain and set sll (https) to true or false\
\
⚠️ Remember that the Client itself need FlatUI.dll. And also the .NET Framework 4.0 (or upper), it is supported by default in Windows 10 but older Windows can require to install it manually.\
You can download and install it manually [here](https://www.microsoft.com/en-us/download/details.aspx?id=17851) from Windows XP (SP 2 for x86_64 and SP 3 for x86) to Windows 10

## License
[GNU General Public License v3.0](https://github.com/EnergyCube/RolePlay_Notes/blob/main/LICENSE)

## ScreenShots
* Login\
![image](https://raw.githubusercontent.com/EnergyCube/RolePlay_Notes/main/screenshots/login.PNG)

* Money Manager\
![image](https://raw.githubusercontent.com/EnergyCube/RolePlay_Notes/main/screenshots/money_manager.PNG)

* Information Management (Intelligence) \
![image](https://raw.githubusercontent.com/EnergyCube/RolePlay_Notes/main/screenshots/rens_search.PNG)

* Resource Manager\
![image](https://raw.githubusercontent.com/EnergyCube/RolePlay_Notes/main/screenshots/ress_manager.PNG)
