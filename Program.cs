using ParkingSystem;

Console.WriteLine("Welcome to the Parking System");
ParkingLot parkingLot = new ParkingLot(6);

while (true)
{
    string input = Console.ReadLine();
    string[] command = input.Split(' ');

    switch (command[0])
    {
        case "create_parking_lot":
            try
            {
                parkingLot = new ParkingLot(int.Parse(command[1]));
                Console.WriteLine($"Created a parking lot with {command[1]} slots");
                break;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Invalid command");
                break;
            }
        case "park":
            if (command[3] == "Mobil" || command[3] == "Motor") {
                parkingLot.Park(new Vehicle(command[1], command[2], command[3]));
                break;
            }
            Console.WriteLine("Type of vehicle is invalid");
            break;
        case "leave":
            parkingLot.Leave(int.Parse(command[1]));
            break;
        case "status":
            parkingLot.Status();
            break;
        case "type_of_vehicles":
            parkingLot.typeOfVehicles(command[1]);
            break;
        case "registration_numbers_for_vehicles_with_ood_plate":
            parkingLot.GetOddRegistNum();
            break;
        case "registration_numbers_for_vehicles_with_event_plate":
            parkingLot.GetEvenRegistNum();
            break;
        case "registration_numbers_for_vehicles_with_colour":
            parkingLot.GetRegistNumByColor(command[1]);
            break;
        case "slot_numbers_for_vehicles_with_colour":
            parkingLot.GetSlotNumByColor(command[1]);
            break;
        case "slot_number_for_registration_number":
            parkingLot.GetSlotNumByRegistNum(command[1]);
            break;
        case "exit":
            return;
        default:
            Console.WriteLine("Invalid command");
            break;
    }
}