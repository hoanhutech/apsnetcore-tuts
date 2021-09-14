#ASP NET CORE 3.1 TUTORIALS
#TUT1 ASP.NET CORE 3.1 REST API 
# Commander project begin
# add ssh key for github
ssh-keygen -t rsa -b 4096 -C "hoanhutech10@gmail.com" 
# ssh key pair generated in ~/hoanh/.ssh/
# default key name
id_rsa # private key
id_rsa.pub #public key
# config ssh-agent auto start with git-bash
# https://docs.github.com/en/github/authenticating-to-github/connecting-to-github-with-ssh/generating-a-new-ssh-key-and-adding-it-to-the-ssh-agent
Adding your SSH key to the ssh-agent
Before adding a new SSH key to the ssh-agent to manage your keys, you should have checked for existing SSH keys and generated a new SSH key.
If you have GitHub Desktop installed, you can use it to clone repositories and not deal with SSH keys.

Ensure the ssh-agent is running. You can use the "Auto-launching the ssh-agent" instructions in "Working with SSH key passphrases", or start it manually:

# start the ssh-agent in the background
$ eval "$(ssh-agent -s)"
> Agent pid 59566
Add your SSH private key to the ssh-agent. If you created your key with a different name, or if you are adding an existing key that has a different name, replace id_ed25519 in the command with the name of your private key file.

$ ssh-add ~/.ssh/id_rsa
Add the SSH key to your account on GitHub. For more information, see "Adding a new SSH key to your GitHub account."
#install dotnet entity frameworkcore
dotnet tool install --global dotnet-ef