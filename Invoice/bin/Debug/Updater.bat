@echo off
%0\ 
cd %0\..
cd /d %0\.. 
timeout 1
if exist Faktury2.exe del Faktury.exe
if not exist Faktury.exe ren Faktury2.exe Faktury.exe
start Faktury.exe
