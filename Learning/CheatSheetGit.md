# Git & Git Bash Cheat Sheet

A personal reference for the Git and Git Bash commands I use while
working on my C# learning repository.

> [!NOTE]
> Useful information that users should know, even when skimming content.

> [!TIP]
> Helpful advice for doing things better or more easily.

> [!IMPORTANT]
> Key information users need to know to achieve their goal.

> [!WARNING]
> Urgent info that needs immediate user attention to avoid problems.

> [!CAUTION]
> Advises about risks or negative outcomes of certain actions.


# Notes

mkdir
  ↓
make a DIRECTORY (folder)

touch
  ↓
make a FILE

---
# 🖥️ Useful Git Bash Commands
| Command | What I think of it as |
|---|---|
| `pwd` | Where am I? |
| `ls` | What's here? |
| `ls -l` | What's here + file details? |
| `cd folder` | Go into this folder |
| `cd ..` | Go up one folder |
| `mkdir folder` | Make a directory/folder |
| `touch file` | Make a file |
| `mv old new` | Move or rename something |
| `rm file` | Remove a file |
| `code file` | Open the file in VS Code |
| `code .` | Open this folder in VS Code |
| `git init` | Turn this folder into a Git repository |
| `git status` | What's changed? |
| `git diff` | What changed inside the files? |
| `git add .` | Stage everything |
| `git commit -m "..."` | Save a snapshot |
| `git log --oneline` | Show my commit history |
| `git remote -v` | Show connected remotes |
| `git push` | Send my commits to GitHub |


# 🌱 Git Mental Model

| Concept | What I think of it as |
|---|---|
| Working directory | The files I'm currently working on |
| Staging area | Changes I've selected for my next commit |
| Commit | A saved snapshot of my changes |
| Local repository | My Git history on my computer |
| Remote / `origin` | The GitHub repository connected to mine |
| `git push` | Send my local commits to GitHub |


# 🧠 Things I Want to Remember

- `git status` → What's happening right now?
- `git diff` → What exactly changed?
- `git add` → What do I want in my next snapshot?
- `git commit` → Save that snapshot locally.
- `git push` → Send my commits to GitHub.
- `git status` saying **"ahead by X commits"** means I have commits locally that haven't been pushed yet.
- `nothing to commit, working tree clean` means I have no uncommitted changes.
- `git rm --cached` → Stop tracking something with Git, but keep it on my computer.

# 📍 Navigation

## `pwd`

Shows the folder I am currently in.

`pwd`



## `ls`

List the files and folders in the current location

`ls`

## `Cd`

Chenges the current directory

`cd folderName`

Go back one folder:

 `cd ..`

# 📁 Creating Files and Folders

## `mkdir`

Creates a new directory (folder).

`mkdir FolderName`

Multiple folders can be created:

`mkdir Level01 Level02 Level03`

## `touch`

Creates a new empty file.

`touch filename.md`

Multiple files:

`touch README.md LearningPath.md CheatSheet.md`

## `code`

Opens a file in Visual Studio Code.

`code filename`

Open the current folder in VS Code:

`code .`

# 🌱 Creating a Git Repository

## `git init`

Initializes Git in the current folder.

`git init`

This turns the current folder into a Git repository.

it creates a hiden `.git` folder containing Git's information about the repository

# 🔎 Checking the Repository

## `git status`

Shows what Git currently knows about the state of the repository.

`git status`

# 📦 Staging Changes

## `git add`

Moves changes into the staging area.

Add one file:

`git add FileName`

add a folder:

`git add FolderName/`

add everything 

`git add ..`


# Deleting

## `rm`

Delete files like

`rm FileName`

