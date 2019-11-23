import socket
import json

host = '192.168.42.22' 
port = 50000
backlog = 5 
size = 1024 
s = socket.socket(socket.AF_INET, socket.SOCK_STREAM) 
s.bind((host,port)) 
s.listen(backlog) 

#while 1:
print("waiting...")
client, address = s.accept() 
print("Client connected.")
client.send(b"WTF man, why was it not working on 25th")
'''	
	
    while 1:
        data = client.recv(size)
        if data == "ping":
            print ("Unity Sent: " + str(data))
            client.send(b"pong")
        else:
            client.send("Bye!")
            print ("Unity Sent Something Else: " + str(data))
            client.close()
            break'''