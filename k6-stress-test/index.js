import http from "k6/http";
import { sleep, check } from "k6";

export const options = {
  stages: [{ duration: "1m", target: 2000 }],
};

export default () => {
  const responseCreatePointRecord = http.post(
    "http://localhost:5113/PointRecord"
  );
  check(responseCreatePointRecord, {
    "Post CreatePointRecord Ok": (r) => r.status === 200,
  });
  sleep(1);
};
