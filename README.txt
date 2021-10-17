To run the model in the correct way:
Create Nodes -> Start Simulation -> Click 'send Data' to let a random node transmit

Dont do it to often because there will be a lot transmissions

Bit of code explanation:
NodesLocationArray: This is the array where the nodes are stored that are randomly made with 'create nodes'

TransmissionArray: This is a predefined array of 2000 elements where the different sending jobs are placed in, with 
		   the use of Jobstart and Jobend a queue idea is made by adding jobs to the end and doing jobs from
		   the front.

CollisionArray: Array where all the nodes are added that are currently sending, their cirkel range is also added.	
		All the currently sending nodes are tested on collision with their neighbours
   
RetransmissionArray: Array where jobs are placed that need to be resend, they all have a second value which is a
		     random delay that counts till 0 so de sendJob can be added to the transmissionArray again

PS: I could have combined few arrays but for simplicity I didnt do it (yet), could always be improved 