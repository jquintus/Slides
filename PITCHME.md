# Vim

![logo](assets/logo.png)

---

## A quick history

* ed
  * `g/re/p`
  * `w`, `q`
* ex
  * `:`
* vi
* vi for the amiga -> vim

---

## Table Of Contents

* Exiting Vim
* Modes
* Vim Philosophy
* Demo

---

## Exit Vim

* `:wqa` - Write (save) Quit All (open files)
* `:q` - Quit without saving anything
  * Will fail if any file has unsaved changes
* `:q!` - Quit without saving anything, I really mean it

---

## Modes

Seriously, this is a good thing

---

## The Modes of Vim

* Normal
* Insert
* Visual
* Command Line

---

## Normal Mode

* The mode vim starts in
* Bang on `esc` to get back to it
* Move around
* Issue commands
* The `.` command

---

## Insert Mode

* The one where you get to type stuff (boring)
* Enter with:
  * `i`/`I` insert in front of curser/line
  * `a`/`A` insert after cursor/line
  * `o`/`O` insert below/above line
* Exit with `esc`

---

## Visual Mode

* Used to select things
* Charater, line, or block based
  * `v`, `V`, `<c-v>`
* Exit by 
  * Issuing a normal mode command (copy/delete/etc)
  * Pressing `esc`

---

## Command Line Modes

* Run `ex` commands (`:`)
* Search using a regex (`/`)
* Exit by
  * Issuing the command/search (`enter`)
  * Cancelling (`esc`)
* Create a config by listing these commands in a file read at startup

---

##  Vim Philosophy

---

##  Vim Philosophy:  Using Modes

1. Move around in normal mode
1. Short bursts in insert mode
1. Tedious work becomes simple with `.`
1. Bulk changes can be "scripted" with command line mode

---

##  Vim Philosophy:  Commands

The same key issues the same command, but in different ways.

```txt
i -> Insert before the cursor
I -> Insert before the first character on the line

a -> Insert after the cursor
A -> Insert after the last character on the line
```

---

##  Vim Philosophy:  Commands

The same key issues the same command, but in different ways.

```txt
cc        -> Cut the entire line and enter insert mode
C         -> Cut the rest of the line and enter insert mode
c{motion} -> Cut the text described by {modtion} 
             and enter insert mode

yy        -> Yank (copy) the entire line
y{motion} -> Yank (copy) the text described by {modtion} 
```

---

## Demo

1. Create a config
1. Format a document using an external tool
1. Create and use mappings to make tedious work simpler
1. Moving around (searching through logs)
1. Doing the same thing across multiple files
1. Redoing work (implement a large interface quickly)

---

## Resources

* [vim.org](http://vim.org)
* [Tim Pope](https://github.com/tpope)
* [Cheat Sheet](http://bfy.tw/J6VM)
