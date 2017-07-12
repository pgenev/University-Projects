import os, time
import ast
import sys
import subprocess as sp

def main():

        with open("ip_addresses.txt", "r") as fread:
            ip_list = fread.read().split("\n")
            ip_list = ip_list[:-1]

        not_connected_ip_addresses = []
        childA ,parentA = os.pipe()
        childB, parentB = os.pipe()
        pidA = os.fork()

        if pidA < 0:
            sys.exit("Fork failed!")

        if pidA > 0:
            print("I'm the main Parent process. Here we are writing the content of the file!")
            time.sleep(2)
            os.close(childA)
            parentA = os.fdopen(parentA, "w")
            parentA.write(str(ip_list))
            parentA.close()

        elif pidA == 0:
            time.sleep(2)
            print("\nI'm the main Child process.Here we are reading the content!")
            os.close(parentA)
            childA = os.fdopen(childA)
            content = childA.read()
            ip_addresses = ast.literal_eval(content)
            childA.close()

            while len(ip_addresses) != 0:
                pidB = os.fork()

                if pidB > 0:
                    time.sleep(2)
                    ip = ip_addresses.pop()
                    print("\nI'm the secondary Parent process.I'm trying to ping the IP address %s!" %(ip))
                    status, result = sp.getstatusoutput("ping -c1 -w2 " + ip)
                    time.sleep(2)

                    if status == 0:
                        print("The ip address " + ip + " is UP!")
                        os.kill(pidB, 9)
                    elif status != 0:
                        print("The ip address " + ip + " is DOWN!")
                        not_connected_ip_addresses.append(ip)
                        os.kill(pidB, 9)

                    if len(ip_addresses) == 0:
                        pidA = os.fork()
                        if pidA == 0:
                            print("\nI'm the main Child process.I'm sending the failed\
                                IP addresses to the main Parent process!")
                            os.close(childB)
                            parentB = os.fdopen(parentB, "w")
                            parentB.write(str(not_connected_ip_addresses))
                            parentB.close()
                            os._exit(0)
                        elif pidA > 0:
                            time.sleep(2)
                            print("\nI'm the main Parent process.My task is to show the failed IP addresses!")
                            os.close(parentB)
                            childB = os.fdopen(childB)
                            not_connected = childB.read()
                            failed_addresses = ast.literal_eval(not_connected)
                            for ip_adr in failed_addresses:
                                time.sleep(5)
                                print("The IP address %s don't Respond!" % (ip_adr))
                            childB.close()
                            os.kill(pidB, 9)
                            os.kill(pidA, 9)
                            break
                elif pidB == 0:
                    os._exit(0)
            os._exit(0)

if __name__ == "__main__":
    main()







