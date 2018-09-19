
# WebAPI

## Architektura

![Architektura](/images/architecture.png)

## XML Web Services
- Podejście RCP (_Remote Call Procedure_)
- wykorzystuje protokół HTTP
- protokół SOAP wyrażony jest w formacie XML

### Tworzenie klienta SOAP

#### Generowanie w Visual Studio

1. Wybierz opcję z menu projektu `References->Add Service Reference->Advanced->Add Web Reference`
1. Podaj adres pliku WSDL, np. ``` http://domain.com/service1.asmx?wsdl ```


1. Naciśnij przycisk **Add reference**

Zostanie wygenerowana klasa proxy.

#### Generowanie z command line

1. Przejdź do SDK

``` bash
cd C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin>
```

1.  Generowanie klasy proxy
``` bash
wsdl.exe PexWsdl.wsdl /out:c:\path\
```

Zostanie wygenerowana klasa proxy.

3. Dodaj wygenerowany plik cs do projektu

4. Dodaj referencję do projektu do _System.Web.Services_

## WCF
- Podejście RCP (_Remote Call Procedure_) ale oparte o interfejsy
- Obsługuje różne komunikacje
- Oparte na konfiguracji pliku
- Obsługuje xml ale można zdefiniować inne formaty

## WebAPI
- Podejście oparte na zasobach
- Prosta adresacja
- Wykorzystuje protokół HTTP
- Obsługuje json, xml ale można zdefiniować inne formaty


## Narzędzia

  - **Balsamiq** - aplikacja do szkicowania interfejsu użytkownika (płatna)


## Przebieg szkolenia
1. Utworzenie klienta do usługi SOAP na podst. pliku WSDL

## Zadania

### Zadanie #1
Musimy utworzyć obsługę bankomatu wg następujących założeń:
- Bankomat powinien obsługiwać wypłaty, wpłaty oraz sprawdzenie salda 
- Akcje powinny być symulowane poprzez wypisanie nazwy akcji i kwoty na konsoli, np. _"Wypłacono 50 zł"_



### Zadanie 1

## Biblioteki
 - AutoMapper
 - 