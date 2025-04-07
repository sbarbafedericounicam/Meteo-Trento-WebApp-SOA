# Progetto: Bollettino Meteo Trentino

Progetto risalente al 2024, sviluppato per il corso di applicazioni web, mobile e cloud (modulo 2).
Applicazione web ASP.NET Core MVC per visualizzare il bollettino meteo della provincia di Trento.

## Funzionalità principali
- Lettura del servizio REST JSON fornito dalla Regione Trentino Alto Adige
- Visualizzazione dati in interfaccia web con immagini dal servizio meteorologico
- Servizio SOAP che converte i dati REST in SOAP
- Ricerca del meteo per giorno specifico tramite servizio SOAP

## Dati utilizzati
Endpoint REST:  
`https://www.meteotrentino.it/protcivtnmeteo/api/front/previsioneOpenDataLocalita?localita=TRENTO`

## Tecnologie utilizzate
- ASP.NET Core MVC
- Servizi REST/JSON
- Servizi SOAP/XML
