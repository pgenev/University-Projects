#config IP address of new machine and add to List

#have to be new every time
NewServiceName = "onePC2" 


IPNetwork = "192.168.56."
#path to file with IPs

pathToFileIps = "IpTable.txt"

f = open(pathToFileIps, "r")

arrNumbers = []

#read file 

for line in f:
    arrIPandName = line.split()
    machineIP = arrIPandName[1]
    machineName = arrIPandName[0]
    #print ("Name {} -> Ip {}".format(machineName, machineIP))
    
    arrSpiltIp = machineIP.split(".")
    lastNumber = arrSpiltIp[3]
    arrNumbers.append(lastNumber)
    
    
f.close()

#find next ip

nextIP = 0;

for i in range(1, 255):
    if(`i` in arrNumbers):
        continue
    else:
        nextIP = i;
        break
        
if (nextIP == 0):
    raise NameError('No more free IP')

completeNewIp = IPNetwork + `nextIP`       
print ("service: {} ip: {}".format(NewServiceName, completeNewIp))  

#write to file
f = open(pathToFileIps, "a")

f.write("{} {}\n".format(NewServiceName, completeNewIp))

f.close()

echoNetwork = IPNetwork + `1`
echoBroadcast = IPNetwork + `255`       
echoNetmask = "255.255.255.0"
#print command to set Static IP Address
print("\n")

print ('sudo echo "iface eth1 inet static \n \
     address {} \n \
     netmask {} \n\
     network {} \n\
     broadcast {} " >> /etc/network/interfaces'.format(completeNewIp,echoNetmask,echoNetwork,echoBroadcast))


