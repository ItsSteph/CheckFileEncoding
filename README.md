# check_your_encoding

A nuget for encoding detection of the 3 most common encodings with BOM. 

- UTF-8
- UTF-16(BE)
- UTF-16(LE)

## Getting Started

### Installing

To install CheckFileEncoding, run the following command in [Package Manager Console](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-powershell)

```
Install-Package CheckFileEncoding 
```

To install CheckFileEncoding, open a command line, switch to the directory that contains you project file and run the command below

```
dotnet add package CheckFileEncoding 
```


### Usage/Examples

```
using CheckFileEncoding

//you can use the premade chain to go through all the encoding checks
var chain = Factory.EncodingChain;

//Call ClientCodeMethod and add the chain and path to the file you want to check
Client.ClientCode(chain, @"c:\users\username\Desktop\file_name.txt");

//Or you can call the methods one at a time
var utf8 = new UTF8Handler();

//Add the path to the file you want to check
utf8.Handle(@"c:\users\username\desktop\file_name.txt");

//If the encoding is found. Response should be something like this: 
The document is encoded with UTF16(LE)/LittleEndian

//If not, it should be something like this: 
Document is not encoded with UTF16(LE)/LittleEndian.
Please try another.
```


## Built With

* [Refactoring Guru](https://refactoring.guru/design-patterns/chain-of-responsibility/csharp/example) - The design pattern used

## Contributing

Contributions are always welcome!

## Authors

*[ItsSteph](https://github.com/ItsSteph)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

[MIT](https://choosealicense.com/licenses/mit/)

## Acknowledgments

* [Marcus Medina](https://github.com/marcusjobb) - Factory and Chain Of Responsibility structure
* [2Toad](https://stackoverflow.com/questions/3825390/effective-way-to-find-any-files-encoding) - https://stackoverflow.com/questions/3825390/effective-way-to-find-any-files-encoding - Codeinspiration
* [cheng-chen](https://stackoverflow.com/users/323924/cheng-chen) - https://stackoverflow.com/questions/3404199/how-to-find-out-the-encoding-of-a-file-c-sharp
