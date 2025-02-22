# EasyJob - Piattaforma di gestione lavorativa

EasyJob è una piattaforma intuitiva per la gestione delle opportunità lavorative, sviluppata con ASP.NET per il backend e senza framework frontend esterni.

## 🚀 Tecnologie Utilizzate
- **ASP.NET Core MVC** - Per la gestione del backend
- **Razor Views** - Per il rendering dinamico delle pagine
- **Entity Framework Core** - Per l'interazione con il database
- **Tailwind CSS** - Per uno stile moderno e responsive
- **JavaScript Vanilla** - Per le funzionalità interattive

## 📂 Struttura del Progetto
```
EasyJob/
├── Controllers/        # Logica delle pagine (HomeController, JobsController, ecc.)
├── Models/            # Modelli dei dati
├── Views/             # Pagine Razor (cshtml)
├── wwwroot/           # Risorse statiche (CSS, JS, immagini)
├── appsettings.json   # Configurazione dell'app
├── Program.cs         # Punto di ingresso dell'applicazione
└── Startup.cs         # Configurazione dei servizi e del middleware
```

## ⚙️ Installazione e Avvio
1. **Clona il repository**
   ```sh
   git clone https://github.com/tuo-username/easyjob.git
   cd easyjob
   ```

2. **Installa le dipendenze**
   ```sh
   dotnet restore
   ```

3. **Configura il database**
   - Apri `appsettings.json` e imposta la stringa di connessione.
   - Esegui la migrazione del database:
     ```sh
     dotnet ef database update
     ```

4. **Avvia l'applicazione**
   ```sh
   dotnet run
   ```

L'applicazione sarà accessibile all'indirizzo `http://localhost:5000`.

## 📌 Funzionalità Principali
- 🔎 Ricerca e filtraggio lavori
- 📄 Pagine dinamiche con Razor
- 🔐 Autenticazione e gestione utenti
- 📊 Dashboard interattiva

## 📜 Licenza
Questo progetto è rilasciato sotto la licenza MIT.

---
**Autore:** Giovanni Colabella

