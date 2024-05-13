# Stateful Timed Rules
Data is time series; we need raise events with custom conditions.

# Keywords
data pipelines, finite-state automata, data parallel

# Requirements
- Nguồn dữ liệu dạng chuỗi thời gian -> cần service get/pub/sub/queue
- Job chạy được khởi động khi: có dữ liệu mới, chạy định kỳ
- Job sẽ tính toán trong 1 khung thời gian xác định (90 ngày trở về trước), ý tưởng ban đầu là có bộ đệm các records chứ xử lý và data đã/đang xử lý
- Around 8 rules
- Event Processor -> Event Factory (manage: data params, which rules, job type)

## Rules
### Right Seat Currency - Captain recency
- Start monitoring once the 'Right Seat Currency B737' User Certificate exists
- Perform in the right seat as a PF and PM (2 sectors) within 12 months

# Refs
 - [Rules Engine](https://github.com/microsoft/RulesEngine)
- [Data-Parallel Finite-State Machines](https://www.microsoft.com/en-us/research/wp-content/uploads/2016/02/asplos302-mytkowicz.pdf)

# Tasks
[ ] Using RulesEngine
[ ] Build Pub/Sub
