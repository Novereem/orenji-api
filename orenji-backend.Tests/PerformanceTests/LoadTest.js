import http from 'k6/http';
import {sleep, check} from 'k6';

export const options = {
    stages: [
        { duration: '30s', target: 150 },
        { duration: '1s', target: 150 },
        { duration: '30s', target: 150 },
    ],
    thresholds: {
        http_req_duration: ['p(99)<200'],
        http_req_failed: ['rate<0.01'],
    },
};

const base_url = 'http://localhost:6000'
export default () => {
    const responses = http.batch([
        ['GET', `${base_url}/tutorial/start/a`]
    ])
    check(responses[0], {
        'status is' : res => res.status === 200
    })
    sleep(1);
}