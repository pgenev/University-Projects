f = open("IpTable.txt", "r")

for line in f:
    arrIPandName = line.split()
    machineIP = arrIPandName[1]
    machineName = arrIPandName[0]
    print ("Name {} -> Ip {}".format(machineName, machineIP))

f.close()
