from subprocess import check_call, CalledProcessError

#Name of the VM.
vmName = "Windows7Script"
#Type of the operating system. In this case is Windows 7 32-bit.
vmOSType = "Windows7"
#RAM of the VM
vmRAM = "1024MB"
#Path to the Virtual HDD
vmHDPath = "/home/philip/Volumes/STORAGE/VirtualMachines/"
#Name of the Virtual HDD
vmHDName = "Windows7Script.vdi"
#Capacity of the Virtual HDD
vmHDCapacity = "16000MB"
#StartPath CD
StartCDPath = ""
#Port for vrde
PortVRDE = ""
#Port forward
PordForward = ""

CREATE_MACHINE_VIA_SHELL = 'VBoxManage createvm --name "Windows7Script" --ostype Windows7 --register'

CONFIG_MACHINE_VIA_SHELL = 'VBoxManage modifyvm "Windows7Script" --memory 1024 --acpi on --boot1 dvd --nic1 hostonly --nic2 nat'

CREATE_VIRTUAL_HDD_VIA_SHELL = 'VBoxManage createhd --filename "/home/philip/Volumes/STORAGE/VirtualMachines/Windows7Script.vdi" --size 16000'

ADD_CONTROLLER_VIA_SHELL = 'VBoxManage storagectl "Windows7Script" --name "IDE Controller" --add ide --controller PIIX4'

ATTACH_VIRTUAL_HDD_TO_MACHINE_VIA_SHELL = 'VBoxManage storageattach "Windows7Script" --storagectl "IDE Controller" --port 0 --device 0 --type hdd --medium "/home/philip/Volumes/STORAGE/VirtualMachines/Windows7Script.vdi"'

MOUNT_ISO_IMAGE_VIA_SHELL = 'VBoxManage storageattach "Windows7Script" --storagectl "IDE Controller" --port 0 --device 1 --type dvddrive --medium "/home/philip/Documents/Win7AIO-SP1-17in1-x86-en-US-Sep2013.iso"'

ADD_PORT_FOR_CONNECTION_VIA_SHELL = 'VBoxManage modifyvm "Windows7Script" --vrdeport 5003'

PORT_FORWARD_VIA_SHELL = 'VBoxManage modifyvm "Windows7Script" --natpf1 "RDP,tcp,,5003,,5003"'

START_VM_VIA_SHELL = 'VBoxHeadless --startvm "Windows7Script" &'
#START_VM_VIA_SHELL = 'VBoxManage startvm Windows7Script --type headless'

class VirtualMachine():

	def __init__(self):
		pass

	def create_machine(self):
		print('\n')
		try:
			process = check_call(CREATE_MACHINE_VIA_SHELL, shell=True)
			return True
		except CalledProcessError as e:
			print (e)

	def config_machine(self):
		print('\n')
		try:
			process = check_call(CONFIG_MACHINE_VIA_SHELL, shell=True)
			print ("The configuration of the machine is completed.")
			return True
		except CalledProcessError as e:
			print (e)

	def create_hdd(self):
		print('\n')
		try:
			process = check_call(CREATE_VIRTUAL_HDD_VIA_SHELL, shell=True)
			print ("The creation of the Hard Disk is completed.")
			return True
		except CalledProcessError as e:
			print (e)
	
	def add_controller(self):
		print('\n')
		try:
			process = check_call(ADD_CONTROLLER_VIA_SHELL, shell=True)
			print ("The IDE controller was added.")
			return True
		except CalledProcessError as e:
			print (e)

	def attach_virtual_hdd(self):
		print('\n')
		try:
			process = check_call(ATTACH_VIRTUAL_HDD_TO_MACHINE_VIA_SHELL, shell=True)
			print ("The Virtual Hard Disk was attached.")
			return True
		except CalledProcessError as e:
			print (e)

	def mount_iso_image(self):
		print('\n')
		try:
			process = check_call(MOUNT_ISO_IMAGE_VIA_SHELL, shell=True)
			print ("The ISO image was mounted.")
			return True
		except CalledProcessError as e:
			print (e)
	
	def add_port(self):
		print('\n')
		try:
			process = check_call(ADD_PORT_FOR_CONNECTION_VIA_SHELL, shell=True)
			print ("The port for the connection was added.")
			return True
		except CalledProcessError as e:
			print (e)

	def port_forward(self):
		print('\n')
		try:
			process = check_call(PORT_FORWARD_VIA_SHELL, shell=True)
			print ("Port forwarding completed.")
			return True
		except CalledProcessError as e:
			print (e)

	def start_vm(self):
		print('\n')
		try:
			process = check_call(START_VM_VIA_SHELL, shell=True)
			print ("Starting VM...")
			return True
		except CalledProcessError as e:
			print (e)
	

def main():
	vm = VirtualMachine()
	vm.create_machine()
	vm.config_machine()
	vm.create_hdd()
	vm.add_controller()
	vm.attach_virtual_hdd()
	vm.mount_iso_image()
	vm.add_port()
	vm.port_forward()
	# vm.start_vm()

if __name__ == "__main__":
	main()

































