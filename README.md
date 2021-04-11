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
✨ InnoSetup Script (See ./setup/setup.iss)\
🗔 From Windows XP* to Windows 10\
🍷 Working on Linux with Wine* !

*:  Need a manual installation of the .NET Framework >= 4


## 📖 Notes
![image](https://raw.githubusercontent.com/EnergyCube/RolePlay_Notes/main/screenshots/tek_hub.png)\
This project was developed as part of a hub project at Epitech (Tek 1).

## 🌐 Setup the Server

To be able to use the RolePlay Notes Client you need to install a Web Server (publicly available) and MariaDB (only available locally).

For Ubuntu (or Debian based) :
```bash
sudo apt update
sudo apt install mariadb-server
sudo mysql_secure_installation
sudo apt install apache2
sudo apt install php
```

After that place files from ./web to your web server folder :

```bash
cp -R ./web [your web server folder (probably /var/www/html)]
```

And finally open the PHP API (./web/api.php)
* Replace the following values by the values of your SQL MariaDB Server :

```php
$db_user = 'your_db_user'; // probably root
$db_password = 'your_db_password';
$db_host = 'localhost';
```

* Create all tables & Create a new user inside a group (See CreateGroup function in the PHP API)
  

## 💻Build the Client

📝 Note : You can also use the Pre-Compiled [Client Setup](https://github.com/EnergyCube/RolePlay_Notes/releases/latest).\
⚠️ But you will need to edit the config.ini before using it.
##

You will need [Visual Studio 2019](https://visualstudio.microsoft.com/vs/) and the .NET Framework 4.0.\
You will also need FlatUI.dll (here is my [fork](https://github.com/EnergyCube/FlatUI/releases/latest)), place it in the client folder.\
\
You are now ready to build the application ! Open the Solution, select Release and Build !\
\
Now go to [Build the Setup](https://github.com/EnergyCube/RolePlay_Notes#build-the-setup) if you want to provide it.\
Otherwise, if you only want it for yourself, open the generated binary, you will get a configuration error, open the configuration file and manually add the server ip/domain and set ssl (https) to false/true.
And your are ready to use RolePlay Notes !

##

⚠️ Remember that the Client itself need FlatUI.dll. And also the .NET Framework 4.0 (or upper), it is supported by default in Windows 10 but older Windows can require to install it manually.\
You can download and install it manually [here](https://www.microsoft.com/en-us/download/details.aspx?id=17851) from Windows XP (SP 2 for x86_64 and SP 3 for x86) to Windows 10

## 📥Build the Setup

After the generation of the Client you need to make one small modification in the setup generation script.\
Replace the following values by the values of your server :

```cpp
; Set your server ip / domain
#define ServerIpOrDomain "server_ip_or_domain"

; Define whether your server supports SSL (HTTPS)
; This is highly recommended, it will secure all communications.
; including user authentication and data sent/transmitted.
; MUST be true or false
#define SupportSSL "true"
```

Once done, generate the setup, and you are ready to use and distribute RolePlay Notes.

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
