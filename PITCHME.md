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

## Features

* Modes (Seriously, this is a good thing)
* Plugins
* Customizable
* Moving Around
* Tips and Tricks

---

## Modes

* Normal
* Insert
* Visual
* Command Line

+++

## Normal

* The mode vim starts in
* Bang on `esc` to get back to it
* Move around
* Issue commands
* The `.` command

+++

## Insert

* The one where you get to type stuff (boring)
* Enter with:
  * `i`/`I` insert in front of curser/line
  * `a`/`A` insert after cursor/line
  * `o`/`O` insert below/above line
  * `c<movement>`/`cc`/`C`
    * Change `<movement>`
    * Change line
    * Change remainder of the line
* Exit with `esc`

+++

## Insert

* Repeat with
  * numbers before command:
* `.` command

`2A,<esc>` -> `,,`

---

## Plugins

> Any sufficiently complicated set of Vim plugins contains an ad hoc, informally-specified, bug-ridden, slow implementation of half of Vim's features.

-- [r/vim](https://www.reddit.com/r/vim/wiki/10th_rule)

---

## Customizable

---

## Moving Around

+++

## Moving around the boring/slow way

* `j`/`k`/`h`/`l`
  * Move cursor up/down/left/right (use your right hand)
  * Prefix with a number to move multiple times:  to move 24 liup:  `24k`

+++

## Quickly mobing within a line

* `f`/`F` (e.g. `fx`)
  * Jump to next occurrence of character (`x`) on the line

+++

## Quickly within a document

* `gg`/`G`
  * Jump to the first/last line of a file
  * `ggVG` selects an entire file (jump to first line, start selecting, jump to last line)
* `:<number>` 
  * Jump to a line number (`$` means the last line)
* `/regex`
  * Jump to any text matching the regex
  * Cycle to next/prev with `n`/`N`

---

## Tips and Tricks

---

## Resources

* [vim.org](http://vim.org)
* [Tim Pope](https://github.com/tpope/vim-fugitive)
