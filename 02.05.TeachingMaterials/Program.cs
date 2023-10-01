/*5. Teaching materials

    The school year has already started and the 10B grade manager - Annie has to buy a certain number of packets of pens, packets with markers, as well as board cleaner. She is a regular client of a bookstore, so there is a discount for her, which represents some discount percentage of the total amount. Write a program that calculates how much money Annie will need to collect to pay the bill, keeping in mind the following price list:

    • Package of pens - 5.80 lv.
    • Package of markers - 7.20 lv.
    • Board cleaner - 1.20 BGN (per liter)

Input
    From the console read 4 numbers:

    · Number of packages of pens - integer in the range [0...100]
    · Number of packets of markers - integer in the range [0...100]
    · Liters of board cleaner - an integer in the range [0... 50]
    · Discount percentage - integer in the range [0...100]

Output

    Print on the console how much money will Annie need to pay the bill.

    Example Input/Output

      Input 2
            3
            4
            25

     Output 28.5

    Price of packages of pens => 2 * 5.80 = 11.60 BGN 
    Price of marker packages => 3 * 7.20 = 21.60 BGN 
    Price of the board cleaner => 4 * 1.20 = 4.80 BGN 
    Price for all materials => 11.60 + 21.60 + 4.80 = 38.00 BGN 
    Calculating the discount 25% = 0.25 
    Price after discount = 38.00 – (38.00 * 0.25) = 28.50 BGN

      Input 4
            2
            5
            13

     Output 37.932

    Price of packages of pens => 4 * 5.80 = 23.20 BGN 
    Price of marker packages => 2 * 7.20 = 14.40 BGN
    Price of the board cleaner => 5 * 1.20 = 6.00 BGN
    Price for all materials => 23.20 + 14.40 + 6.00 = 43.60 BGN
    Calculating the discount 13% = 0.13
    Price after discount = 43.60 – (43.60 * 0.13) = 37.932 BGN
*/

int pens = int.Parse(Console.ReadLine());
int markers = int.Parse(Console.ReadLine());
int boardCleaner = int.Parse(Console.ReadLine());
int discountPer = int.Parse(Console.ReadLine());

// Price of packages of pens => 2 * 5.80 = 11.60 BGN
double pensPrice = pens * 5.8;

// Price of marker packages => 3 * 7.20 = 21.60 BGN
double markerPrice = markers * 7.2;

// Price of the board cleaner => 4 * 1.20 = 4.80 BGN
double boardCleanerPrice = boardCleaner * 1.2;

// Price for all materials => 11.60 + 21.60 + 4.80 = 38.00 BGN
double allMaterials = pensPrice + markerPrice + boardCleanerPrice;

// Calculating the discount 25 % = 0.25
double discount = discountPer / 100.00;

// Price after discount = 38.00 – (38.00 * 0.25) = 28.50 BGN
double PriceAfterDisc = allMaterials - (allMaterials * discount);

Console.WriteLine(PriceAfterDisc);