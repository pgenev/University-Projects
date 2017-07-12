from vboxapi import VirtualBoxManager

mgr = VirtualBoxManager(None, None)
vbox = mgr.vbox
name = "Windows7Script"
mach = vbox.findMachine(name)
session = mgr.mgr.getSessionObject(vbox)
progress = mach.launchVMProcess(session, "gui", "")
progress.waitForCompletion(-1)
