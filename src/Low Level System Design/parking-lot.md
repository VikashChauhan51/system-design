# ParkingLot

```C#
public class ParkingLot
{
    private int numberOfFloors;
    private List<Floor> floors;

    public ParkingLot(int numberOfFloors)
    {
        this.numberOfFloors = numberOfFloors;
        floors = new List<Floor>();

        for (int i = 0; i < numberOfFloors; i++)
        {
            floors.Add(new Floor(i));
        }
    }

    public void SensorDataReceived(int floorNumber, string sensorType)
    {
        if (sensorType == "A") // Sensor A indicates a vehicle has entered a slot
        {
            if (floors[floorNumber].GetAvailableSlots() > 0)
            {
                floors[floorNumber].DecreaseAvailableSlots();
            }
            else if (floorNumber < numberOfFloors - 1) // If the current floor is full, check the next floor
            {
                SensorDataReceived(floorNumber + 1, sensorType);
            }
            else
            {
                Console.WriteLine("Parking lot is full.");
            }
        }
        else if (sensorType == "B") // Sensor B indicates a vehicle has left a slot
        {
            floors[floorNumber].IncreaseAvailableSlots();
        }
    }

    public void DisplayAvailableSlots()
    {
        foreach (var floor in floors)
        {
            Console.WriteLine("Floor " + floor.GetFloorNumber() + ": " + floor.GetAvailableSlots() + " slots available.");
        }
    }
}

public class Floor
{
    private int floorNumber;
    private int availableSlots;

    public Floor(int floorNumber)
    {
        this.floorNumber = floorNumber;
        this.availableSlots = 10; // Assuming each floor has 10 slots
    }

    public void DecreaseAvailableSlots()
    {
        if (availableSlots > 0)
        {
            availableSlots--;
        }
    }

    public void IncreaseAvailableSlots()
    {
        if (availableSlots < 10) // Assuming each floor has 10 slots
        {
            availableSlots++;
        }
    }

    public int GetAvailableSlots()
    {
        return availableSlots;
    }

    public int GetFloorNumber()
    {
        return floorNumber;
    }
}

```