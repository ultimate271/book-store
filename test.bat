@echo off
del bin\test.exe
csc /out:bin\test.exe src\*.cs /main:Test
bin\test