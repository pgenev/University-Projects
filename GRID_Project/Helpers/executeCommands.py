#!/usr/bin/python
import subprocess

cmd = "VBoxManage list vms"
cmdListAll = "ls -l"

process =  subprocess.Popen(cmdListAll ,shell=True , stdout=subprocess.PIPE)

output = process.communicate()[0]

arrMachines = output.splitlines()

for value in arrMachines :
        print value