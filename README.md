# Pdb-Magician
Parse PDB Files and generates C# class library which helps with interpreting memory images.

Like most things on here this is a bit experimental.

In support of the memory forensics work I'm doing, I wanted to be able to grab the appropriate PDB file
from the Microsoft Symbol Server based on the GUIDAGE of the kernel file.

Next, I parse the file using the SIA SDK and produce a C# class library that allows me
to pass in a byte buffer from the memory image and to interpret the data as strongly typed
member variables for each given structure.

I've also parsed out the Public Symbols which include the constants and the function addresses, 
plus I've parsed the enums.


