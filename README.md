# fiap-postech-hackathon-point-record

## OWASP

Verificação: <a href="./assets/owasp/documento.html">Documento</a>

## Examplos de request

### POST: /PointRecord

```json
NoBody
```

## K6 test

Foi executado um teste de extresse enviando mais de 8 mil solicitações em um periodo de 1 minuto e 20 segundos e todas foram concluidas e registradas no banco de dados com exito, comprovando que a aplicação está apta a suportar os picos de extresse exigidos

```console
          /\      |‾‾| /‾‾/   /‾‾/
     /\  /  \     |  |/  /   /  /
    /  \/    \    |     (   /   ‾‾\
   /          \   |  |\  \ |  (‾)  |
  / __________ \  |__| \__\ \_____/ .io

  execution: local
     script: .\index.js
     output: json (stress-test.json)

  scenarios: (100.00%) 1 scenario, 2000 max VUs, 1m30s max duration (incl. graceful stop):
           * default: Up to 2000 looping VUs for 1m0s over 1 stages (gracefulRampDown: 30s, gracefulStop: 30s)


     ✓ Post CreatePointRecord Ok

     checks.........................: 100.00% ✓ 8469       ✗ 0
     data_received..................: 1.3 MB  15 kB/s
     data_sent......................: 940 kB  11 kB/s
     http_req_blocked...............: avg=254.24µs min=0s     med=0s    max=16.32ms p(90)=1.03ms   p(95)=1.24ms
     http_req_connecting............: avg=214.79µs min=0s     med=0s    max=16.32ms p(90)=818.47µs p(95)=1.08ms
     http_req_duration..............: avg=8.71s    min=1.54ms med=7.05s max=21.46s  p(90)=19.02s   p(95)=20.13s
       { expected_response:true }...: avg=8.71s    min=1.54ms med=7.05s max=21.46s  p(90)=19.02s   p(95)=20.13s
     http_req_failed................: 0.00%   ✓ 0          ✗ 8469
     http_req_receiving.............: avg=273.09µs min=0s     med=0s    max=7.64ms  p(90)=918.58µs p(95)=1.03ms
     http_req_sending...............: avg=45.3µs   min=0s     med=0s    max=6.66ms  p(90)=0s       p(95)=509.53µs
     http_req_tls_handshaking.......: avg=0s       min=0s     med=0s    max=0s      p(90)=0s       p(95)=0s
     http_req_waiting...............: avg=8.71s    min=1.43ms med=7.05s max=21.46s  p(90)=19.02s   p(95)=20.13s
     http_reqs......................: 8469    102.696282/s
     iteration_duration.............: avg=9.71s    min=1s     med=8.06s max=22.47s  p(90)=20.03s   p(95)=21.13s
     iterations.....................: 8469    102.696282/s
     vus............................: 57      min=27       max=1993
     vus_max........................: 2000    min=2000     max=2000


running (1m22.5s), 0000/2000 VUs, 8469 complete and 0 interrupted iterations
default ✓ [======================================] 0000/2000 VUs  1m0s
```
