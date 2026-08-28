# Git & Git Bash Cheat Sheet

A personal reference for the Git and Git Bash commands I use while
working on my C# learning repository.


# Notes

mkdir
  ↓
make a DIRECTORY (folder)

touch
  ↓
make a FILE

---
# 🖥️ Useful Git Bash Commands
| Command               | What I think of it as                  |
| --------------------- | -------------------------------------- |
| `pwd`                 | Where am I?                            |
| `ls`                  | What's here?                           |
| `cd folder`           | Go into this folder                    |
| `cd ..`               | Go up one folder                       |
| `mkdir folder`        | Make a folder                          |
| `touch file`          | Make a file                            |
| `code file`           | Open the file in VS Code               |
| `code .`              | Open this folder in VS Code            |
| `git init`            | Turn this folder into a Git repository |
| `git status`          | What's changed?                        |
| `git add .`           | Stage everything                       |
| `git commit -m "..."` | Save a snapshot                        |
| `git remote -v`       | Show connected remotes                 |
| `git push`            | Send commits to GitHub                 |
| `touch`               |create file                             |


mkdir    → create directory
ls       → see what's here
ls -l    → see details
pwd      → see where I am
mv       → move/rename
rm       → remove

# 📍 Navigation

## `pwd`

Shows the folder I am currently in.

pwd



## `ls`

List the files and folders in the current location

ls

## Cd

Chenges the current directory

cd folderName

Go back one folder:

 cd ..

 # 📁 Creating Files and Folders

## mkdir

Creates a new directory (folder).

mkdir FolderName

Multiple folders can be created:

mkdir Level01 Level02 Level03

## touch

Creates a new empty file.

touch filename.md

Multiple files:

touch README.md LearningPath.md CheatSheet.md

## code

Opens a file in Visual Studio Code.

code filename

Open the current folder in VS Code:

code .

# 🌱 Creating a Git Repository

## git init

Initializes Git in the current folder.

git init

This turns the current folder into a Git repository.

it creates a hiden .git folder containing Git's information about the repository

# 🔎 Checking the Repository

## git status

Shows what Git currently knows about the state of the repository.

git status

# 📦 Staging Changes

## git add

Moves changes into the staging area.

Add one file:

git add FileName

add a folder:

git add FolderName/

add everything 

git add ..


# Deleting

## rm

Delete files like

rm FileName

