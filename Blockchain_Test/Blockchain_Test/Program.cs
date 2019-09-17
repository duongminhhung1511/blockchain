using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blockchain_Test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHash());

            //ITransaction txn1 = new Transaction("ABC123", 1000.00m, DateTime.Now, "QWE123", 10000, ClaimType.TotalLoss);
            //ITransaction txn2 = new Transaction("VBG345", 2000.00m, DateTime.Now, "JKH567", 20000, ClaimType.TotalLoss);
            //ITransaction txn3 = new Transaction("XCF234", 3000.00m, DateTime.Now, "DH23ED", 30000, ClaimType.TotalLoss);
            //ITransaction txn4 = new Transaction("CBHD45", 4000.00m, DateTime.Now, "DH34K6", 40000, ClaimType.TotalLoss);
            //ITransaction txn5 = new Transaction("AJD345", 5000.00m, DateTime.Now, "28FNF4", 50000, ClaimType.TotalLoss);
            //ITransaction txn6 = new Transaction("QAX367", 6000.00m, DateTime.Now, "FJK676", 60000, ClaimType.TotalLoss);
            //ITransaction txn7 = new Transaction("CGO444", 7000.00m, DateTime.Now, "LKU234", 70000, ClaimType.TotalLoss);
            //ITransaction txn8 = new Transaction("PLO254", 8000.00m, DateTime.Now, "VBN456", 80000, ClaimType.TotalLoss);
            //ITransaction txn9 = new Transaction("ABC123", 1000.00m, DateTime.Now, "QWE123", 10000, ClaimType.TotalLoss);
            //ITransaction txn10 = new Transaction("VBG345", 2000.00m, DateTime.Now, "JKH567", 20000, ClaimType.TotalLoss);
            //ITransaction txn11 = new Transaction("XCF234", 3000.00m, DateTime.Now, "DH23ED", 30000, ClaimType.TotalLoss);
            //ITransaction txn12 = new Transaction("CBHD45", 4000.00m, DateTime.Now, "DH34K6", 40000, ClaimType.TotalLoss);
            //ITransaction txn13 = new Transaction("AJD345", 5000.00m, DateTime.Now, "28FNF4", 50000, ClaimType.TotalLoss);
            //ITransaction txn14 = new Transaction("QAX367", 6000.00m, DateTime.Now, "FJK676", 60000, ClaimType.TotalLoss);
            //ITransaction txn15 = new Transaction("CGO444", 7000.00m, DateTime.Now, "LKU234", 70000, ClaimType.TotalLoss);
            //ITransaction txn16 = new Transaction("PLO254", 8000.00m, DateTime.Now, "VBN456", 80000, ClaimType.TotalLoss);


            //IBlock block1 = new Block(0);
            //IBlock block2 = new Block(1);
            //IBlock block3 = new Block(2);
            //IBlock block4 = new Block(3);

            //block1.AddTransaction(txn1);
            //block1.AddTransaction(txn2);
            //block1.AddTransaction(txn3);
            //block1.AddTransaction(txn4);

            //block2.AddTransaction(txn5);
            //block2.AddTransaction(txn6);
            //block2.AddTransaction(txn7);
            //block2.AddTransaction(txn8);

            //block3.AddTransaction(txn9);
            //block3.AddTransaction(txn10);
            //block3.AddTransaction(txn11);
            //block3.AddTransaction(txn12);

            //block4.AddTransaction(txn13);
            //block4.AddTransaction(txn14);
            //block4.AddTransaction(txn15);
            //block4.AddTransaction(txn16);

            //block1.SetBlockHash(null);
            //block2.SetBlockHash(block1);
            //block3.SetBlockHash(block2);
            //block4.SetBlockHash(block3);


            //BlockChain chain = new BlockChain();
            //chain.AcceptBlock(block1);
            //chain.AcceptBlock(block2);
            //chain.AcceptBlock(block3);
            //chain.AcceptBlock(block4);


            //chain.VerifyChain();

            //Console.WriteLine("");
            //Console.WriteLine("");

            //txn5.ClaimNumber = "weqwewe";
            //chain.VerifyChain();

            //Console.WriteLine();



        //    const string originalMessage = "Original Message to hash";
        //    const string originalMessage2 = "Or1ginal Message to hash";

        //    SHA256(originalMessage, originalMessage2);
        //    HMAC(originalMessage, originalMessage2);
        //    DigitalSignatures();
        //}

        //private static void SHA256(string originalMessage, string originalMessage2)
        //{
        //    Console.WriteLine("Hashing Demonstration in .NET");
        //    Console.WriteLine("---------------------------------");
        //    Console.WriteLine();
        //    Console.WriteLine("Original Message 1 : " + originalMessage);
        //    Console.WriteLine("Original Message 2 : " + originalMessage2);
        //    Console.WriteLine();

        //    var sha256HashedMessage = HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(originalMessage));
        //    var sha256HashedMessage2 = HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(originalMessage2));

        //    Console.WriteLine("SHA 256 Hashes");
        //    Console.WriteLine();
        //    Console.WriteLine("Message 1 hash = " + Convert.ToBase64String(sha256HashedMessage));
        //    Console.WriteLine("Message 2 hash = " + Convert.ToBase64String(sha256HashedMessage2));
        //    Console.WriteLine();
        //}

        //private static void HMAC(string originalMessage, string originalMessage2)
        //{
        //    Console.WriteLine("HMAC Demonstration in .NET");
        //    Console.WriteLine("--------------------------");
        //    Console.WriteLine();

        //    var key = Hmac.GenerateKey();

        //    var hmacSha256Message = Hmac.ComputeHmacsha256(Encoding.UTF8.GetBytes(originalMessage), key);
        //    var hmacSha256Message2 = Hmac.ComputeHmacsha256(Encoding.UTF8.GetBytes(originalMessage2), key);

        //    Console.WriteLine();
        //    Console.WriteLine("SHA 256 HMAC");
        //    Console.WriteLine();
        //    Console.WriteLine("Message 1 hash = " + Convert.ToBase64String(hmacSha256Message));
        //    Console.WriteLine("Message 2 hash = " + Convert.ToBase64String(hmacSha256Message2));
        //    Console.WriteLine();
        //}

        //private static void DigitalSignatures()
        //{
        //    var document = Encoding.UTF8.GetBytes("Document to Sign");
        //    byte[] hashedDocument;

        //    hashedDocument = HashData.ComputeHashSha256(document);

        //    var digitalSignature = new DigitalSignature();
        //    digitalSignature.AssignNewKey();

        //    var signature = digitalSignature.SignData(hashedDocument);
        //    var verified = digitalSignature.VerifySignature(hashedDocument, signature);

        //    Console.WriteLine("Digital Signature Demonstration in .NET");
        //    Console.WriteLine("---------------------------------------");
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine("   Original Text = " +
        //        Encoding.Default.GetString(document));

        //    Console.WriteLine();
        //    Console.WriteLine("   Digital Signature = " +
        //        Convert.ToBase64String(signature));

        //    Console.WriteLine();

        //    Console.WriteLine(verified
        //        ? "The digital signature has been correctly verified."
        //        : "The digital signature has NOT been correctly verified.");

        }
    }
}
