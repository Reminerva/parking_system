namespace ParkingSystem
{
    class ParkingLot
    {
        private Dictionary<int, Vehicle> slots;
        private int capacity;

        public ParkingLot(int capacity)
        {
            this.capacity = capacity;
            slots = new Dictionary<int, Vehicle>();
        }

        public void Park(Vehicle vehicle)
        {
            for (int i = 1; i <= capacity; i++)
            {
                if (!slots.ContainsKey(i))
                {
                    slots[i] = vehicle;
                    Console.WriteLine($"Allocated slot number: {i}");
                    return;
                }
            }
            Console.WriteLine("Sorry, parking lot is full");
        }

        public void Leave(int slotNumber)
        {
            if (slots.ContainsKey(slotNumber))
            {
                slots.Remove(slotNumber);
                Console.WriteLine($"Slot number {slotNumber} is free");
            }
            else
            {
                Console.WriteLine("Slot is already empty or does not exist");
            }
        }

        public void Status()
        {
            Console.WriteLine("Slot\tRegistration No\ttype\tColour");
            foreach (var slot in slots)
            {
                Console.WriteLine($"{slot.Key}\t{slot.Value.RegistrationNumber}\t{slot.Value.Type}\t{slot.Value.Color}");
            }
        }

        public void typeOfVehicles(string type)
        {   
            int num = 0;
            foreach (var slot in slots)
            {
                if (slot.Value.Type == type)
                {   
                    num += 1;
                }
            }
            Console.Write(num);
        }

        public void GetOddRegistNum()
        {
            foreach (var slot in slots)
            {
                if (slot.Value.RegistrationNumber.Length % 2 == 1)
                {
                Console.Write($"{slot.Value.RegistrationNumber}, ");
                }
            }
        }

        public void GetEvenRegistNum()
        {
            foreach (var slot in slots)
            {
                if (slot.Value.RegistrationNumber.Length % 2 == 0)
                {
                Console.Write($"{slot.Value.RegistrationNumber}, ");
                }
            }
        }

        public void GetRegistNumByColor(string color)
        {
            foreach (var slot in slots)
            {
                if (slot.Value.Color == color)
                {
                    Console.Write($"{slot.Value.RegistrationNumber}, ");
                }
            }
        }

        public void GetSlotNumByColor(string color)
        {
            foreach (var slot in slots)
            {
                if (slot.Value.Color == color)
                {
                    Console.Write($"{slot.Key}, ");
                }
            }
        }

        public void GetSlotNumByRegistNum(string registNum)
        {
            string output = "";
            foreach (var slot in slots)
            {
                if (slot.Value.RegistrationNumber == registNum)
                {   
                    output += slot.Key.ToString() + ", ";
                    Console.Write(output);
                }
            }
            if (output == "")
            {
                Console.WriteLine("Not found");
            }
        }
    }
}