# WSS

### Testovací web socket server - pre testerov

**rozbehnutie:**

1. je to multiplatformova Net.Core appka otvorime konzolu ideme do foldra s projektom
2. prikaz > ```cd BinarkyNaSpustenie``` 
    > pozn: kto nerad pise tak ```cd B [tab] [enter]```
    > v linuxe dodrziavat velkost pismen
3. prikaz > ```ls (alebo dir vo windows)```
4. vyberieme folder s nasou platformou napr cd Linux-X64
5. spustit binarny subor pre svojku platformu

    - pre windows ```WSS.exe```
    - pre linux ```./WSS``` (vsetko velkym pismenom a bez koncovky)
    - pre Mac OS asi rovnako ako v linuxe
    
6. (vo windows) povoliť port 8181 vo firewalle (system by vas k tomu mal sam vyzvat pri spusteni appky) - v linuxe a na macu som to neskusal ale predpokladam ze rovnako treba povolit niekde tento port.
7. zistit IP svojho PC (windows prikaz ipconfig, linux prikaz ifconfig)
8. do \_config.js na riadok obsahujuci ```WEBSOCKET_SERVER_URL``` zadame nasu ip adresu aj s portom ```8181``` na ktorom bezi nas server takto: 
    ``` javascript
    export const WEBSOCKET_SERVER_URL = 'ws://192.168.129.241:8181';
    ```
    samozrejme kazdy zada inu IP podla toho aku zobrazil predchadzajuci prikaz. Protokol zadame ws nie wss ako bolo povodne. A to je cele vazeni.
9. pokial chceme server zastavit tak stlacime [enter] aplikacia prestane bezat pokial ho chceme znova spustit tak v konzole dame [sipku hore] a [enter]
