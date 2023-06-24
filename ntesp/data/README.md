# `ntesp` - an test Program with `Graphics User Interface`

ntesp is an program for personal uses.

## Installation

### Install from Github Repository

[Click this](https://github.com/ntesp/ntesp-projects/raw/main/publishs/bin/ntesp.exe) or access https://github.com/ntesp/ntesp-projects/raw/main/publishs/bin/ntesp.exe to download `ntesp.exe`.

### Build from Source Code in Visual Studio

Clone Repository using `Github CLI` or `Git`.

using `Github CLI`: `gh repo clone ntesp/ntesp-projects`

using `Git`: `git clone https://github.com/ntesp/ntesp-projects.git`

open `ntesp.vsproj` in your `Visual Studio`.

and click `Start without Debug` from `Debug` Menu Item or click `▶️` button to build.

if you want startup using command line, run this script if the project path has `%USERPROFILE%`, as Your Userprofile directory like `C:\Users\user\`:

```batch
cd %USERPROFILE%/ntesp-projects/publishs/bin/
ntesp -v
```

## Usage

type `ntesp`

`ntesp [options] argument`

|`Number label`|`Arguments`|`Parameter(s) (Optional)`|`Description`|
|:-:|:------:|:------------------:|:---------:|
|**`1`**|`-v`,`--version`| |Display Version Information|
|**`2`**|`-u`, `-usage`||Display Usages of Per program|

## License

this project has licensed `CC-BY-NC-SA-4.0`.