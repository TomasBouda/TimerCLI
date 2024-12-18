# TimerCLI

TimerCLI is a simple command-line application written in C# that functions as a countdown timer. It allows users to set a timer for a specified duration and provides an option to exit the application or continuously beep when the timer ends.

## Features

- Set a timer for a specific duration in hours, minutes, and seconds.
- Tea mode: a quick 3-minute timer.
- Option to exit the application when the timer ends.
- Continuous beeping when the timer ends (if not exiting).

## Usage

### Command Line Options

- `-h, --hours` : Hours to wait (optional).
- `-m, --minutes` : Minutes to wait (optional).
- `-s, --seconds` : Seconds to wait (optional).
- `--exit` : Application will exit after the timer ends (optional).
- `--tea` : Tea mode. Sets the timer to 3 minutes (optional).

### Examples

- Set a timer for 1 hour, 30 minutes, and 45 seconds:
  ```sh
  TimerCLI --hours 1 --minutes 30 --seconds 45
  ```
  
- Set a timer for 10 seconds and run a command when the timer ends: 
  ```sh
  TimerCLI -s 10 --exit; ping google.com
  ```