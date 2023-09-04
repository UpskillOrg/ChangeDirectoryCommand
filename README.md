Write a function to implement the change directory command (cd). The function will take two arguments:

cwd: The current working directory.
cd: The directory to change into.
The function will return the fully qualified resulting path.

Important Points:

There is no file system, so there's no need to verify if paths exist.
There are no null values.
There are no multiple / in a row (e.g., ///).
cwd always starts from the root and is fully qualified.
Examples:

cwd: / cd: baz => Result: /baz
cwd: /foo cd: bar => Result: /foo/bar
cwd: /foo/bar cd: ../../../../.. => Result: /
cwd: /x/y cd: /p/q => Result: /p/q
cwd: /x/y cd: /p/../q => Result: /q
cwd: /x/y cd: ./p/../a/./b => Result: /x/y/a/b
cwd: /foo/bar cd: ../x/./../y => Result: /foo/y
This formatted text provides a clear and concise description of the task and the expected behavior of the cd function, along with examples for better understanding.





